import Navigation from "./Navigation";

export default function PageLayout({ children, lang, setLang, theme, toggleTheme }) {
    return (
        <div className="page-layout">
            <header>
                <div className="container">
                    <Navigation lang={lang} setLang={setLang} theme={theme} toggleTheme={toggleTheme} />
                </div>
            </header>

            <main className="page-main">
                {children}
            </main>
        </div>
    );
}