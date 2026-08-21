import { Routes, Route } from "react-router-dom";

import PageLayout from "./components/layout/PageLayout";
import HeroSection from "./features/hero/HeroSection";
import PortfolioSection from "./features/portfolio/PortfolioSection";
import PortfolioDetailPage from "./features/portfolio/PortfolioDetailPage";

export default function App() {
    const lang = "en";

    return (
        <PageLayout>
            <Routes>
                <Route
                    path="/"
                    element={
                        <>
                            <HeroSection lang={lang} />
                            <PortfolioSection lang={lang} />
                        </>
                    }
                />

                <Route
                    path="/portfolio/:slug"
                    element={<PortfolioDetailPage lang={lang} />}
                />
            </Routes>
        </PageLayout>
    );
}