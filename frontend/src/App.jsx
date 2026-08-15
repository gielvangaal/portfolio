import PageLayout from "./components/layout/PageLayout";
import HeroSection from "./features/hero/HeroSection";
import PortfolioSection from "./features/portfolio/PortfolioSection.jsx";

export default function App() {
    const lang = "en"
    return (
        <PageLayout>
            <HeroSection lang={lang} />
            <PortfolioSection lang={lang} />
        </PageLayout>
    );
}