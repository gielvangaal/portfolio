import Navigation from "./Navigation";

export default function PageLayout({ children, lang, setLang }) {
    return (
        <div className="page-layout">
            <header>
                <div className="container">
                    <Navigation lang={lang} setLang={setLang} />
                </div>
            </header>

            <main className="page-main">
                {children}
            </main>
        </div>
    );
}