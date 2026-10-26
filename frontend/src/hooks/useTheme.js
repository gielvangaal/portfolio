import { useEffect, useLayoutEffect, useState } from "react";

const STORAGE_KEY = "portfolio-theme";

function readPreference() {
    try {
        const value = localStorage.getItem(STORAGE_KEY);
        return value === "light" || value === "dark" ? value : null;
    } catch {
        return null;
    }
}

export function useTheme() {
    const [preference, setPreference] = useState(readPreference);
    const [systemDark, setSystemDark] = useState(
        () => window.matchMedia("(prefers-color-scheme: dark)").matches
    );
    const theme = preference ?? (systemDark ? "dark" : "light");

    useLayoutEffect(() => {
        document.documentElement.dataset.theme = theme;
    }, [theme]);

    useEffect(() => {
        const media = window.matchMedia("(prefers-color-scheme: dark)");
        const onChange = (event) => setSystemDark(event.matches);
        const onStorage = (event) => {
            if (event.key === STORAGE_KEY || event.key === null) {
                setPreference(readPreference());
            }
        };
        media.addEventListener("change", onChange);
        // Catch changes between the initial render and subscribing.
        setSystemDark(media.matches);
        window.addEventListener("storage", onStorage);
        return () => {
            media.removeEventListener("change", onChange);
            window.removeEventListener("storage", onStorage);
        };
    }, []);

    function toggleTheme() {
        const next = theme === "dark" ? "light" : "dark";
        setPreference(next);
        try {
            localStorage.setItem(STORAGE_KEY, next);
        } catch {
            // Toggling still works when the browser blocks storage.
        }
    }

    return { theme, toggleTheme };
}
