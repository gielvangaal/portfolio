import Navigation from "./Navigation";

export default function PageLayout({ children }) {
    return (
        <div className="page-layout">
            <header>
                <div className="container">
                    <Navigation />
                </div>
            </header>

            <main className="page-main">
                <div className="container">
                    {children}
                </div>
            </main>
        </div>
    );
}