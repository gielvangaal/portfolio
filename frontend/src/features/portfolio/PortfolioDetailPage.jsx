import { useState } from "react";
import { useParams } from "react-router-dom";

import { usePortfolioItem } from "./usePortfolioItem";
import PortfolioMedia from "./PortfolioMedia";

import Button from "../../components/ui/Button.jsx";
import Header from "../../components/ui/Header.jsx";
import Badge from "../../components/ui/Badge.jsx";

import "./portfolioDetail.css";

export default function PortfolioDetailPage({ lang }) {
    const { slug } = useParams();
    const [showAllSkills, setShowAllSkills] = useState(false);

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

    const technologies = item.technologies ?? [];
    const tooling = item.tooling ?? [];
    const skills = item.skills ?? [];
    const categories = item.categories ?? [];

    const hasStack =
        technologies.length > 0 ||
        tooling.length > 0 ||
        skills.length > 0;

    const visibleSkills = showAllSkills
        ? skills
        : skills.slice(0, 5);

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

            <Header as="h1">
                {item.title}
            </Header>

            <section className="portfolio-detail__content">
                <div className="portfolio-detail__main">
                    <div className="portfolio-detail__description">
                        <p>{item.description}</p>
                    </div>

                    {hasStack && (
                        <section className="portfolio-detail__stack">
                            {technologies.length > 0 && (
                                <div className="portfolio-detail__stack-group">
                                    <p className="portfolio-detail__stack-label">
                                        Technologie
                                    </p>

                                    <ul className="portfolio-detail__stack-items">
                                        {technologies.map((technology) => (
                                            <li key={technology}>
                                                <Badge variant="technology">
                                                    {technology}
                                                </Badge>
                                            </li>
                                        ))}
                                    </ul>
                                </div>
                            )}

                            {tooling.length > 0 && (
                                <div className="portfolio-detail__stack-group">
                                    <p className="portfolio-detail__stack-label">
                                        Tooling
                                    </p>

                                    <ul className="portfolio-detail__stack-items">
                                        {tooling.map((tool) => (
                                            <li key={tool}>
                                                <Badge variant="tooling">
                                                    {tool}
                                                </Badge>
                                            </li>
                                        ))}
                                    </ul>
                                </div>
                            )}

                            {skills.length > 0 && (
                                <div className="portfolio-detail__stack-group">
                                    <p className="portfolio-detail__stack-label">
                                        Vaardigheden
                                    </p>

                                    <ul className="portfolio-detail__stack-items">
                                        {visibleSkills.map((skill) => (
                                            <li key={skill}>
                                                <Badge variant="skill">
                                                    {skill}
                                                </Badge>
                                            </li>
                                        ))}
                                    </ul>

                                    {skills.length > 5 && (
                                        <button
                                            type="button"
                                            className="portfolio-detail__skills-toggle"
                                            onClick={() =>
                                                setShowAllSkills(
                                                    (current) => !current
                                                )
                                            }
                                        >
                                            {showAllSkills
                                                ? "Minder tonen"
                                                : `+ ${skills.length - 5} meer`}
                                        </button>
                                    )}
                                </div>
                            )}
                        </section>
                    )}
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
                                {item.duration ||
                                item.teamSize ||
                                categories.length > 0
                                    ? "├─"
                                    : "└─"}
                            </dt>
                            <dd>{item.projectDate}</dd>
                        </div>

                        {item.duration && (
                            <div>
                                <dt aria-hidden="true">
                                    {item.teamSize ||
                                    categories.length > 0
                                        ? "├─"
                                        : "└─"}
                                </dt>
                                <dd>{item.duration}</dd>
                            </div>
                        )}

                        {item.teamSize && (
                            <div>
                                <dt aria-hidden="true">
                                    {categories.length > 0
                                        ? "├─"
                                        : "└─"}
                                </dt>
                                <dd>{item.teamSize}</dd>
                            </div>
                        )}

                        {categories.length > 0 && (
                            <div>
                                <dt aria-hidden="true">└─</dt>
                                <dd>{categories.join(" · ")}</dd>
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

            <PortfolioMedia media={item.media} />
        </main>
    );
}