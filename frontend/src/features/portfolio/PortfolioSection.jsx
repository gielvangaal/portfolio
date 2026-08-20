import { useState } from "react";
import "./portfolio.css";
import { usePortfolio } from "./usePortfolio";
import PortfolioCard from "./PortfolioCard";

const PAGE_SIZE = 4;

export default function PortfolioSection({ lang }) {
    const [page, setPage] = useState(0);

    const {
        data: portfolio = [],
        isLoading,
        isError,
    } = usePortfolio(lang);

    if (isLoading) {
        return <p>Portfolio loading...</p>;
    }

    if (isError) {
        return <p>Portfolio could not be loaded.</p>;
    }

    const pageCount = Math.ceil(portfolio.length / PAGE_SIZE);

    const visibleItems = portfolio.slice(
        page * PAGE_SIZE,
        page * PAGE_SIZE + PAGE_SIZE
    );

    return (
        <section id="portfolio" className="portfolio-section">
            <div className="section-heading">
                <h2>Portfolio</h2>
                <div className="section-heading__highlight" />
            </div>

            <div className="portfolio-grid">
                {visibleItems.map((item) => (
                    <PortfolioCard
                        key={item.slug}
                        item={item}
                    />
                ))}
            </div>

            {pageCount > 1 && (
                <div className="portfolio-pagination">
                    <button
                        type="button"
                        onClick={() => setPage((page) => page - 1)}
                        disabled={page === 0}
                    >
                        ←
                    </button>

                    <span>
                        {page + 1} / {pageCount}
                    </span>

                    <button
                        type="button"
                        onClick={() => setPage((page) => page + 1)}
                        disabled={page === pageCount - 1}
                    >
                        →
                    </button>
                </div>
            )}
        </section>
    );
}