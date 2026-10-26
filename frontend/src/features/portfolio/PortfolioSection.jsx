
import { useState } from "react";
import "./portfolio.css";
import { usePortfolio } from "./usePortfolio";
import PortfolioCard from "./PortfolioCard";
import Header from "../../components/ui/Header.jsx";
import { translations } from "./portfolio.translations";

const PAGE_SIZE = 4;

export default function PortfolioSection({ lang }) {
    const [page, setPage] = useState(0);
    const t = translations[lang] ?? translations.nl;

    const {
        data: portfolio = [],
        isLoading,
        isError,
    } = usePortfolio(lang);

    if (isLoading) {
        return <p>{t.loading}</p>;
    }

    if (isError) {
        return <p>{t.error}</p>;
    }

    const pageCount = Math.ceil(portfolio.length / PAGE_SIZE);

    const visibleItems = portfolio.slice(
        page * PAGE_SIZE,
        page * PAGE_SIZE + PAGE_SIZE
    );

    const handleNextPage = () => {
        setPage((currentPage) =>
            currentPage === pageCount - 1
                ? 0
                : currentPage + 1
        );

        document
            .getElementById("portfolio")
            ?.scrollIntoView({
                behavior: "smooth",
                block: "start",
            });
    };

    return (
        <section
            id="portfolio"
            className="portfolio-section"
        >
            <Header>
                {t.title}
            </Header>

            <div className="portfolio-grid">
                {visibleItems.map((item) => (
                    <PortfolioCard
                        key={item.slug}
                        item={item}
                        lang={lang}
                    />
                ))}
            </div>

            {pageCount > 1 && (
                <div className="portfolio-pagination">
                    <button
                        type="button"
                        onClick={handleNextPage}
                        aria-label={t.nextPage}
                    >
                        {page + 1} / {pageCount}
                    </button>
                </div>
            )}
        </section>
    );
}
