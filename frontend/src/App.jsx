import { useLayoutEffect } from "react";
import { Routes, Route, useLocation } from "react-router-dom";

import PageLayout from "./components/layout/PageLayout";
import HeroSection from "./features/hero/HeroSection";
import PortfolioSection from "./features/portfolio/PortfolioSection";
import PortfolioDetailPage from "./features/portfolio/PortfolioDetailPage";
import AboutProfileSection from "./features/aboutProfile/AboutProfileSection";

// T.b.v. automatische scroll naar hash
function ScrollToHash() {
    const { pathname, hash } = useLocation();

    useLayoutEffect(() => {
        if (!hash) {
            window.scrollTo({ top: 0, left: 0, behavior: "instant" });
            return;
        }

        const targetId = decodeURIComponent(hash.slice(1));

        const scrollToTarget = () => {
            const target = document.getElementById(targetId);

            if (!target) return false;

            target.scrollIntoView({ behavior: "instant", block: "start" });
            return true;
        };

        if (scrollToTarget()) return;

        const observer = new MutationObserver(() => {
            if (scrollToTarget()) observer.disconnect();
        });

        observer.observe(document.body, {
            childList: true,
            subtree: true,
        });

        return () => observer.disconnect();
    }, [pathname, hash]);

    return null;
}

export default function App() {
    const lang = "nl";
    const { pathname } = useLocation();

    return (
        <>
            <ScrollToHash />

            <div key={pathname} className="page-fade-in">
                <PageLayout>
                    <Routes>
                        <Route
                            path="/"
                            element={
                                <>
                                    <HeroSection lang={lang} />
                                    <PortfolioSection lang={lang} />
                                    <AboutProfileSection lang={lang} />
                                </>
                            }
                        />

                        <Route
                            path="/portfolio/:slug"
                            element={<PortfolioDetailPage lang={lang} />}
                        />
                    </Routes>
                </PageLayout>
            </div>
        </>
    );
}
