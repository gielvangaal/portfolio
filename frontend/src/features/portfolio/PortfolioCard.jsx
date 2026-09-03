import Button from "../../components/ui/Button.jsx";
import Badge from "../../components/ui/Badge.jsx";
import Header from "../../components/ui/Header.jsx";

export default function PortfolioCard({ item }) {
    const technologies = item.technologies.slice(0, 3);
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

            <Header as="h3">
                {item.title}
            </Header>

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