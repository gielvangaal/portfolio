import { useState } from "react";

import { useTechnologies } from "./useTechnologies";
import Header from "../../components/ui/Header.jsx";

import "./technologies.css";

export default function TechnologySection() {
    const {
        data: technologies = [],
        isLoading,
        isError,
    } = useTechnologies();

    const filters = [
        { value: "All", label: "Alles" },
        { value: "Daily", label: "Dagelijks" },
        { value: "Regular", label: "Regelmatig" },
        { value: "Occasional", label: "Soms" },
        { value: "Past", label: "Lang geleden" },
    ];

    const [usageFilter, setUsageFilter] = useState("Daily");

    const filteredTechnologies =
        usageFilter === "All"
            ? technologies
            : technologies.filter(
                (technology) => technology.usage === usageFilter
            );

    if (isLoading) {
        return <p>Technologies loading...</p>;
    }

    if (isError) {
        return <p>Technologies could not be loaded.</p>;
    }

    return (
        <section
            id="webstack"
            className="webstack-section"
        >
            <div className="webstack-container">
                <Header as="h3">
                    Webstack
                </Header>

                <div
                    className="webstack-filters"
                    aria-label="Filter technologieën"
                >
                    {filters.map((filter) => (
                        <button
                            key={filter.value}
                            type="button"
                            className={`webstack-filter ${
                                usageFilter === filter.value
                                    ? "webstack-filter--active"
                                    : ""
                            }`}
                            onClick={() => setUsageFilter(filter.value)}
                        >
                            {filter.label}
                        </button>
                    ))}
                </div>

                <ul
                    className="webstack-grid"
                    aria-label="Webstack"
                >
                    {filteredTechnologies.map((technology) => (
                        <li
                            key={technology.id}
                            className="webstack-item"
                        >
                            <figure>
                                {technology.media && (
                                    <img
                                        src={technology.media.path}
                                        alt={technology.media.altText}
                                        loading="lazy"
                                    />
                                )}

                                <figcaption>
                                    {technology.name}
                                </figcaption>
                            </figure>
                        </li>
                    ))}
                </ul>
            </div>
        </section>
    );
}