import "./portfolioMedia.css";

export default function PortfolioMedia({ media }) {
    if (!media?.length) {
        return null;
    }

    const sortedMedia = [...media].sort(
        (a, b) => a.sortOrder - b.sortOrder
    );

    return (
        <section className="portfolio-media">
            {sortedMedia.map((image) => (
                <img
                    key={image.path}
                    src={image.path}
                    alt={image.altText}
                    loading="lazy"
                />
            ))}
        </section>
    );
}