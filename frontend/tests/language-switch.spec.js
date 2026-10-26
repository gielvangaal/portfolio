import { test, expect } from "@playwright/test";

// Integration coverage against the locally running, seeded API on port 5000.
test("NL → EN → NL updates every section and preserves softskill groups", async ({ page, request }) => {
    const errors = [];
    page.on("pageerror", (error) => errors.push(error.message));
    const paths = ["education", "skills", "work-experience", "library", "portfolio"];
    const data = {};
    for (const lang of ["nl", "en"]) {
        data[lang] = {};
        for (const path of paths) {
            const response = await request.get(`http://localhost:5000/api/${path}?language=${lang}`);
            expect(response.ok()).toBeTruthy();
            data[lang][path] = await response.json();
        }
        const response = await request.get(`http://localhost:5000/api/contact/${lang}`);
        expect(response.ok()).toBeTruthy();
        data[lang].contact = await response.json();
    }

    await page.goto("/");
    for (const lang of ["nl", "en", "nl"]) {
        if (lang === "en") {
            const responses = paths.map((path) => page.waitForResponse((response) => {
                const url = new URL(response.url());
                return url.pathname === `/api/${path}` && url.searchParams.get("language") === "en" && response.ok();
            }));
            responses.push(page.waitForResponse((response) => response.url().endsWith("/api/contact/en") && response.ok()));
            await page.getByRole("button", { name: "EN", exact: true }).click();
            await Promise.all(responses);
        } else {
            await page.getByRole("button", { name: "NL", exact: true }).click();
        }
        await expect(page.locator("html")).toHaveAttribute("lang", lang);
        await expect(page.getByRole("button", { name: lang.toUpperCase(), exact: true })).toHaveAttribute("aria-pressed", "true");
        await expect(page.locator("#education")).toContainText(data[lang].education[0].program);
        await expect(page.locator("#werkervaring")).toContainText(data[lang]["work-experience"][0].role);
        await expect(page.locator("#contact")).toContainText(data[lang].contact.creditText);
        await expect(page.locator("#library")).toContainText(lang === "en" ? "Bookshelf" : "Boekenplank");
        const groups = page.locator(".softskills-group");
        await expect(groups).toHaveCount(3);
        for (const [index, count] of [9, 8, 9].entries()) {
            await expect(groups.nth(index).locator(".badge")).toHaveCount(count);
        }
        const skill = data[lang].skills.find((item) => item.key === "solution-oriented-thinking");
        await expect(page.locator("#softskills")).toContainText(skill.name);
        await expect(page.locator("#education h3").first()).toHaveText(lang === "en" ? "Education" : "Onderwijs");
        await expect(page.locator("#werkervaring h3").first()).toHaveText(lang === "en" ? "Work experience" : "Werkervaring");
    }
    expect(errors).toEqual([]);
});

test("language switching works on project details and survives client navigation", async ({ page, request }) => {
    const response = await request.get("http://localhost:5000/api/portfolio?language=nl");
    expect(response.ok()).toBeTruthy();
    const [project] = await response.json();
    await page.goto(`/portfolio/${project.slug}`);
    await expect(page.getByRole("link", { name: "Terug", exact: true })).toBeVisible();
    const translated = page.waitForResponse((response) => response.url().endsWith(`/api/portfolio/${project.slug}/en`) && response.ok());
    await page.getByRole("button", { name: "EN", exact: true }).click();
    const english = await (await translated).json();
    await expect(page.locator(".portfolio-detail__description")).toHaveText(english.description);
    await page.getByRole("link", { name: "Back", exact: true }).click();
    await expect(page.locator("#education h3").first()).toHaveText("Education");
    await expect(page.getByRole("button", { name: "EN", exact: true })).toHaveAttribute("aria-pressed", "true");
});
