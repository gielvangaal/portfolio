import Button from "../../components/ui/Button.jsx";
import Badge from "../../components/ui/Badge.jsx";

export default function PortfolioCard({ item }) {
    const technologies = item.technologies.slice(0, 3port);
    const tooling = item.tooling.slice(0, 2);

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
                        <Badge variant="technology">
                            {technology}
                        </Badge>
                    </li>
                ))}

                {tooling.map((tool) => (
                    <li key={tool}>
                        <Badge variant="tooling">
                            {tool}
                        </Badge>
                    </li>
                ))}
            </ul>

            <Button
                variant="primary"
                className="portfolio-card__button"
                to={`/portfolio/${item.slug}`}
            >
                Meer
            </Button>
        </article>
    );
}