import { useParams } from "react-router-dom";

import { usePortfolioItem } from "./usePortfolioItem";
import PortfolioMedia from "./PortfolioMedia";
import "./portfolioDetail.css";
import Button from "../../components/ui/Button.jsx";

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

            <header className="portfolio-detail__header">
                <h1>{item.title}</h1>
                <div
                    className="portfolio-detail__heading-highlight"
                    aria-hidden="true"
                />
            </header>

            <section className="portfolio-detail__content">
                <div className="portfolio-detail__description">
                    <p>{item.description}</p>
                </div>

                <aside
                    className="portfolio-detail__details"
                    aria-label="Projectdetails"
                >
                    <dl>
                        <div>
                            <dt>Project</dt>
                            <dd>{item.projectType}</dd>
                        </div>

                        <div>
                            <dt>Rol</dt>
                            <dd>{item.role}</dd>
                        </div>

                        <div>
                            <dt>Datum</dt>
                            <dd>{item.projectDate}</dd>
                        </div>

                        {item.duration && (
                            <div>
                                <dt>Duur</dt>
                                <dd>{item.duration}</dd>
                            </div>
                        )}

                        {item.teamSize && (
                            <div>
                                <dt>Team</dt>
                                <dd>{item.teamSize}</dd>
                            </div>
                        )}
                    </dl>

                    {item.technologies.length > 0 && (
                        <div className="portfolio-detail__meta">
                            <p className="portfolio-detail__meta-label">
                                Stack
                            </p>

                            <ul>
                                {item.technologies.map((technology) => (
                                    <li key={technology}>
                                        {technology}
                                    </li>
                                ))}
                            </ul>
                        </div>
                    )}

                    {item.categories.length > 0 && (
                        <div className="portfolio-detail__meta">
                            <p className="portfolio-detail__meta-label">
                                Categorieën
                            </p>

                            <p>{item.categories.join(" · ")}</p>
                        </div>
                    )}

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

            <PortfolioMedia media={item.media} />
        </main>
    );
}
