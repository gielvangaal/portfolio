import { Moon, Sun } from "lucide-react";

import { Link } from "react-router-dom";

import { translations } from "./navigation.translations";
import "./navigation.css";

export default function Navigation({ lang = "nl", setLang, theme, toggleTheme }) {
    const t = translations[lang] ?? translations.nl;

    return (
        <nav className="navigation" aria-label={t.navigationLabel}>
            <Link to="/#home">{t.home}</Link>
            <Link to="/#portfolio">{t.portfolio}</Link>
            <Link to="/#about">{t.about}</Link>
            <Link to="/#contact">{t.contact}</Link>

            <div className="navigation-controls">
                <div className="language-switcher" role="group" aria-label={t.languageLabel}>
                    <button
                        type="button"
                        className={lang === "nl" ? "active" : ""}
                        aria-pressed={lang === "nl"}
                        onClick={() => setLang("nl")}
                    >
                        NL
                    </button>

                    <span className="language-switcher__separator" aria-hidden="true">/</span>

                    <button
                        type="button"
                        className={lang === "en" ? "active" : ""}
                        aria-pressed={lang === "en"}
                        onClick={() => setLang("en")}
                    >
                        EN
                    </button>
                </div>
                <button
                    type="button"
                    className="theme-toggle"
                    onClick={toggleTheme}
                    aria-label={theme === "dark" ? t.switchToLight : t.switchToDark}
                    title={theme === "dark" ? t.switchToLight : t.switchToDark}
                >
                    {theme === "dark"
                        ? <Sun size={20} strokeWidth={1.75} aria-hidden="true" />
                        : <Moon size={20} strokeWidth={1.75} aria-hidden="true" />}
                </button>
            </div>
        </nav>
    );
}
