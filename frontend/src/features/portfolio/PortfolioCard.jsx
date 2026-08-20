export default function PortfolioCard({ item }) {
    const technologies = item.technologies.slice(0, 4);

    return (
        <article className="portfolio-card">
            {item.primaryImageUrl && (
                <img
                    className="portfolio-card__image"
                    src={item.primaryImageUrl}
                    alt=""
                    loading="lazy"
                />
            )}

            <div className="portfolio-card__heading">
                <h3>{item.title}</h3>
                <div
                    className="portfolio-card__heading-highlight"
                    aria-hidden="true"
                />
            </div>

            <div className="portfolio-card__meta">
                <span>{item.projectType}</span>
                <span>·</span>
                <span>{item.role}</span>
            </div>

            <p className="portfolio-card__description">
                {item.cardDescription}
            </p>

            <ul className="portfolio-card__technologies">
                {technologies.map((technology) => (
                    <li key={technology}>
                        {technology}
                    </li>
                ))}
            </ul>

            <a
                className="portfolio-card__button"
                href={`/portfolio/${item.slug}`}
            >
                Meer
            </a>
        </article>
    );
}