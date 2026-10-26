import { Link } from "react-router-dom";

import { translations } from "./navigation.translations";
import "./navigation.css";

export default function Navigation({ lang = "nl", setLang }) {
    const t = translations[lang] ?? translations.nl;

    return (
        <nav className="navigation" aria-label={t.navigationLabel}>
            <Link to="/#home">{t.home}</Link>
            <Link to="/#portfolio">{t.portfolio}</Link>
            <Link to="/#about">{t.about}</Link>
            <Link to="/#contact">{t.contact}</Link>

            <div className="language-switcher" role="group" aria-label={t.languageLabel}>
                <button
                    type="button"
                    className={lang === "nl" ? "active" : ""}
                    aria-pressed={lang === "nl"}
                    onClick={() => setLang("nl")}
                >
                    NL
                </button>

                <span aria-hidden="true">|</span>

                <button
                    type="button"
                    className={lang === "en" ? "active" : ""}
                    aria-pressed={lang === "en"}
                    onClick={() => setLang("en")}
                >
                    EN
                </button>
            </div>
        </nav>
    );
}