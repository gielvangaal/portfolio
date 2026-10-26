import { test, expect } from "@playwright/test";

const themeButton = (page) => page.getByRole("button", { name: /thema inschakelen|Switch to .* theme/ });

test("follows system changes until a manual choice, then remembers that choice", async ({ page }) => {
    await page.emulateMedia({ colorScheme: "dark" });
    await page.goto("/");
    await expect(page.locator("html")).toHaveAttribute("data-theme", "dark");
    await expect(themeButton(page)).toHaveAccessibleName("Licht thema inschakelen");
    await page.emulateMedia({ colorScheme: "light" });
    await expect(page.locator("html")).toHaveAttribute("data-theme", "light");
    await themeButton(page).click();
    await expect(page.locator("html")).toHaveAttribute("data-theme", "dark");
    await expect.poll(() => page.evaluate(() => localStorage.getItem("portfolio-theme"))).toBe("dark");
    await page.emulateMedia({ colorScheme: "dark" });
    await page.emulateMedia({ colorScheme: "light" });
    await expect(page.locator("html")).toHaveAttribute("data-theme", "dark");
    await page.reload();
    await expect(page.locator("html")).toHaveAttribute("data-theme", "dark");
    await themeButton(page).click();
    await page.reload();
    await expect(page.locator("html")).toHaveAttribute("data-theme", "light");
});

test("applies stored theme before React loads and ignores invalid stored values", async ({ page }) => {
    await page.emulateMedia({ colorScheme: "light" });
    await page.addInitScript(() => localStorage.setItem("portfolio-theme", location.search ? "invalid" : "dark"));
    await page.route(/\/src\/main\.jsx(?:\?.*)?$/,  (route) => route.abort());
    await page.goto("/");
    await expect(page.locator("html")).toHaveAttribute("data-theme", "dark");
    await expect(page.locator("#root")).toBeEmpty();
    await page.goto("/?invalid-theme");
    await expect(page.locator("html")).toHaveAttribute("data-theme", "light");
});

test("works with blocked storage and translates its accessible label", async ({ page }) => {
    await page.emulateMedia({ colorScheme: "light" });
    await page.addInitScript(() => {
        Storage.prototype.getItem = () => { throw new Error("Storage blocked"); };
        Storage.prototype.setItem = () => { throw new Error("Storage blocked"); };
    });
    await page.goto("/");
    await themeButton(page).click();
    await expect(page.locator("html")).toHaveAttribute("data-theme", "dark");
    await page.getByRole("button", { name: "EN", exact: true }).click();
    await expect(themeButton(page)).toHaveAccessibleName("Switch to light theme");
    await themeButton(page).focus();
    await page.keyboard.press("Enter");
    await expect(page.locator("html")).toHaveAttribute("data-theme", "light");
});

test("controls fit mobile navigation and retain theme during navigation", async ({ page }) => {
    await page.setViewportSize({ width: 375, height: 812 });
    await page.emulateMedia({ colorScheme: "dark" });
    await page.goto("/");
    await expect(page.locator(".portfolio-card__button").first()).toBeVisible();
    for (const control of await page.locator(".navigation button, .navigation a").all()) {
        const box = await control.boundingBox();
        expect(box.x).toBeGreaterThanOrEqual(0);
        expect(box.x + box.width).toBeLessThanOrEqual(375);
    }
    await expect(page.locator(".language-switcher__separator")).toHaveText("/");
    await page.locator(".portfolio-card__button").first().click();
    await expect(page.locator(".portfolio-detail")).toBeVisible();
    await expect(page.locator("html")).toHaveAttribute("data-theme", "dark");
});
