
import { useState } from "react";

import { useTechnologies } from "./useTechnologies";
import { useTooling } from "../tooling/useTooling";

import Header from "../../components/ui/Header.jsx";
import WebstackItem from "../../components/ui/WebstackItem.jsx";

import { translations } from "./technologies.translations";
import "./technologies.css";

function FilterSelect({ label, filters, selected, onSelect }) {
    return (
        <label className="webstack-select">
            <span className="visually-hidden">{label}</span>

            <select
                className="webstack-select__control"
                value={selected}
                onChange={(event) => onSelect(event.target.value)}
            >
                {filters.map((filter) => (
                    <option
                        key={filter.value}
                        value={filter.value}
                    >
                        {filter.label}
                    </option>
                ))}
            </select>
        </label>
    );
}

export default function TechnologySection({ lang = "nl" }) {
    const t = translations[lang] ?? translations.nl;

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

    const [typeFilter, setTypeFilter] = useState("All");
    const [usageFilter, setUsageFilter] = useState("Daily");

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

    const filteredItems = items.filter(
        (item) =>
            (typeFilter === "All" || item.type === typeFilter) &&
            (usageFilter === "All" || item.usage === usageFilter)
    );

    if (technologiesLoading || toolingLoading) {
        return <p>{t.loading}</p>;
    }

    if (technologiesError || toolingError) {
        return <p>{t.error}</p>;
    }

    return (
        <section id="webstack" className="webstack-section">
            <div className="webstack-container">
                <Header as="h3">{t.title}</Header>

                <div className="webstack-filter-groups">
                    <FilterSelect
                        label={t.typeLabel}
                        filters={t.typeFilters}
                        selected={typeFilter}
                        onSelect={setTypeFilter}
                    />

                    <FilterSelect
                        label={t.usageLabel}
                        filters={t.usageFilters}
                        selected={usageFilter}
                        onSelect={setUsageFilter}
                    />
                </div>

                {filteredItems.length > 0 ? (
                    <ul
                        className="webstack-grid"
                        aria-label={t.title}
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
                ) : (
                    <p>{t.noResults}</p>
                )}
            </div>
        </section>
    );
}
