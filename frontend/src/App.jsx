import PageLayout from "./components/layout/PageLayout";
import HeroSection from "./features/hero/HeroSection";

export default function App() {
    const lang = "en"
    return (
        <PageLayout>
            <HeroSection lang={lang} />
        </PageLayout>
    );
}