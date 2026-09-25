import { useState } from "react";

import { useTechnologies } from "./useTechnologies";
import { useTooling } from "../tooling/useTooling";

import Badge, {
    BadgeVariant,
} from "../../components/ui/Badge.jsx";
import Header from "../../components/ui/Header.jsx";

import "./technologies.css";
import WebstackItem from "../../components/ui/WebstackItem.jsx";

export default function TechnologySection() {
    const {
        data: technologies = [],
        isLoading: technologiesLoading,
        isError: technologiesError,
    } = useTechnologies();

    const {
        data: tooling = [],
        isLoading: toolingLoading,
        isError: toolingError,
    } = useTooling();

    const [usageFilter, setUsageFilter] = useState("Daily");

    const filters = [
        { value: "All", label: "Alles" },
        { value: "Daily", label: "Dagelijks" },
        { value: "Regular", label: "Regelmatig" },
        { value: "Occasional", label: "Soms" },
        { value: "Past", label: "Lang geleden" },
    ];

    const items = [
        ...technologies.map((technology) => ({
            ...technology,
            type: "technology",
        })),
        ...tooling.map((tool) => ({
            ...tool,
            type: "tooling",
        })),
    ];

    const filteredItems =
        usageFilter === "All"
            ? items
            : items.filter(
                (item) => item.usage === usageFilter
            );

    if (technologiesLoading || toolingLoading) {
        return <p>Stack loading...</p>;
    }

    if (technologiesError || toolingError) {
        return <p>Stack could not be loaded.</p>;
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
                    aria-label="Filter stack"
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
                            onClick={() =>
                                setUsageFilter(filter.value)
                            }
                        >
                            <span className="webstack-filter__content">
                                <span
                                    className="webstack-filter__highlight"
                                    aria-hidden="true"
                                />

                                <span className="webstack-filter__label">
                                    [ {filter.label} ]
                                </span>
                            </span>
                        </button>
                    ))}
                </div>

                <ul
                    className="webstack-grid"
                    aria-label="Webstack"
                >
                    {filteredItems.map((item) => (
                        <li
                            key={`${item.type}-${item.id}`}
                            className="webstack-grid__item"
                        >
                            <WebstackItem item={item} />
                        </li>
                    ))}
                </ul>
            </div>
        </section>
    );
}