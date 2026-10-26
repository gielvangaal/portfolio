import { defineConfig } from "@playwright/test";

export default defineConfig({
    testDir: "./tests",
    use: {
        baseURL: "http://localhost:5173",
        launchOptions: process.env.PLAYWRIGHT_CHROMIUM_EXECUTABLE_PATH
            ? { executablePath: process.env.PLAYWRIGHT_CHROMIUM_EXECUTABLE_PATH }
            : {},
    },
    webServer: {
        command: "npm run dev -- --host 127.0.0.1 --port 5173 --strictPort",
        url: "http://localhost:5173",
        env: { VITE_API_BASE_URL: "http://localhost:5000" },
        reuseExistingServer: !process.env.CI,
    },
});
