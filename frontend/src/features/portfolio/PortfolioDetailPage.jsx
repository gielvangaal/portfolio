import { useParams } from "react-router-dom";

import { usePortfolioItem } from "./usePortfolioItem";
import PortfolioMedia from "./PortfolioMedia";
import "./portfolioDetail.css";
import Button from "../../components/ui/Button.jsx";
import Header from "../../components/ui/Header.jsx";
import Badge from "../../components/ui/Badge.jsx";

export default function PortfolioDetailPage({ lang }) {
    const { slug } = useParams();

    const {
        data: item,
        isLoading,
        isError,
    } = usePortfolioItem(slug, lang);

    if (isLoading) {
        return <p>Portfolio loading...</p>;
    }

    if (isError || !item) {
        return <p>Portfolio could not be loaded.</p>;
    }

    const hasStack =
        item.technologies.length > 0 ||
        (item.tooling?.length ?? 0) > 0 ||
        (item.skills?.length ?? 0) > 0;

    return (
        <main className="portfolio-detail">
            <Button
                variant="primary"
                className="portfolio-back-link"
                to="/#portfolio"
            >
                Terug
            </Button>

            <br />
            <br />
            <br />

            <Header as="h1">{item.title}</Header>

            <section className="portfolio-detail__content">
                <div className="portfolio-detail__main">
                    <div className="portfolio-detail__description">
                        <p>{item.description}</p>
                    </div>
                </div>

                <aside
                    className="portfolio-detail__details"
                    aria-label="Projectdetails"
                >

                    <p className="portfolio-detail__details-label">
                        <b>Projectinfo</b>
                    </p>

                    <dl className="portfolio-detail__facts">
                        <div>
                            <dt aria-hidden="true">├─</dt>
                            <dd>{item.projectType}</dd>
                        </div>

                        <div>
                            <dt aria-hidden="true">├─</dt>
                            <dd>{item.role}</dd>
                        </div>

                        <div>
                            <dt aria-hidden="true">
                                {item.duration || item.teamSize || item.categories.length > 0
                                    ? "├─"
                                    : "└─"}
                            </dt>
                            <dd>{item.projectDate}</dd>
                        </div>

                        {item.duration && (
                            <div>
                                <dt aria-hidden="true">
                                    {item.teamSize || item.categories.length > 0 ? "├─" : "└─"}
                                </dt>
                                <dd>{item.duration}</dd>
                            </div>
                        )}

                        {item.teamSize && (
                            <div>
                                <dt aria-hidden="true">
                                    {item.categories.length > 0 ? "├─" : "└─"}
                                </dt>
                                <dd>{item.teamSize}</dd>
                            </div>
                        )}

                        {item.categories.length > 0 && (
                            <div>
                                <dt aria-hidden="true">└─</dt>
                                <dd>{item.categories.join(" · ")}</dd>
                            </div>
                        )}
                    </dl>

                    {(item.gitHubUrl || item.liveSiteUrl) && (
                        <div className="portfolio-detail__links">
                            {item.gitHubUrl && (
                                <a
                                    className="portfolio-button"
                                    href={item.gitHubUrl}
                                    target="_blank"
                                    rel="noreferrer"
                                >
                                    GitHub ↗
                                </a>
                            )}

                            {item.liveSiteUrl && (
                                <a
                                    className="portfolio-button"
                                    href={item.liveSiteUrl}
                                    target="_blank"
                                    rel="noreferrer"
                                >
                                    Live site ↗
                                </a>
                            )}
                        </div>
                    )}
                </aside>

            </section>

            {hasStack && (
                <section className="portfolio-detail__stack">
                    {item.technologies.length > 0 && (
                        <div className="portfolio-detail__stack-group">
                            <p className="portfolio-detail__stack-label">
                                Technologie
                            </p>

                            <ul className="portfolio-detail__stack-items">
                                {item.technologies.map((technology) => (
                                    <li key={technology}>
                                        <Badge variant="technology">
                                            {technology}
                                        </Badge>
                                    </li>
                                ))}
                            </ul>
                        </div>
                    )}

                    {(item.tooling?.length ?? 0) > 0 && (
                        <div className="portfolio-detail__stack-group">
                            <p className="portfolio-detail__stack-label">
                                Tooling
                            </p>

                            <ul className="portfolio-detail__stack-items">
                                {item.tooling.map((tool) => (
                                    <li key={tool}>
                                        <Badge variant="tooling">
                                            {tool}
                                        </Badge>
                                    </li>
                                ))}
                            </ul>
                        </div>
                    )}

                    {(item.skills?.length ?? 0) > 0 && (
                        <div className="portfolio-detail__stack-group">
                            <p className="portfolio-detail__stack-label">
                                Vaardigheden
                            </p>

                            <ul className="portfolio-detail__stack-items">
                                {item.skills.map((skill) => (
                                    <li key={skill}>
                                        <Badge variant="skill">
                                            {skill}
                                        </Badge>
                                    </li>
                                ))}
                            </ul>
                        </div>
                    )}
                </section>
            )}

            <PortfolioMedia media={item.media} />
        </main>
    );
}