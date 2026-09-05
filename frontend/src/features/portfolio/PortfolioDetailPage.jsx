import { useParams } from "react-router-dom";

import { usePortfolioItem } from "./usePortfolioItem";
import PortfolioMedia from "./PortfolioMedia";

import Button from "../../components/ui/Button.jsx";
import Header from "../../components/ui/Header.jsx";
import TagGroups from "../../components/ui/TagGroups.jsx";

import "./portfolioDetail.css";

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

    const technologies = item.technologies ?? [];
    const tooling = item.tooling ?? [];
    const skills = item.skills ?? [];
    const categories = item.categories ?? [];

    const hasTags =
        technologies.length > 0 ||
        tooling.length > 0 ||
        skills.length > 0;

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

                    {hasTags && (
                        <div className="portfolio-detail__tags">
                            <TagGroups
                                technologies={technologies}
                                tooling={tooling}
                                skills={skills}
                                skillLimit={5}
                            />
                        </div>
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
                                <dd>
                                    {categories.join(" · ")}
                                </dd>
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