import { useState } from "react";

import { useTechnologies } from "./useTechnologies";
import { useTooling } from "../tooling/useTooling";

import Header from "../../components/ui/Header.jsx";
import WebstackItem from "../../components/ui/WebstackItem.jsx";

import "./technologies.css";

const typeFilters = [
    { value: "All", label: "Alles" },
    { value: "technology", label: "Tech" },
    { value: "tooling", label: "Tools" },
];

const usageFilters = [
    { value: "All", label: "Alles" },
    { value: "Daily", label: "Dagelijks" },
    { value: "Regular", label: "Regelmatig" },
    { value: "Occasional", label: "Soms" },
    { value: "Past", label: "Lang geleden" },
];

function FilterSelect({ label, filters, selected, onSelect }) {
    return (
        <label className="webstack-select">

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
        return <p>Stack loading...</p>;
    }

    if (technologiesError || toolingError) {
        return <p>Stack could not be loaded.</p>;
    }

    return (
        <section id="webstack" className="webstack-section">
            <div className="webstack-container">
                <Header as="h3">Webstack</Header>

                <div className="webstack-filter-groups">
                    <FilterSelect
                        label="Type"
                        filters={typeFilters}
                        selected={typeFilter}
                        onSelect={setTypeFilter}
                    />

                    <FilterSelect
                        label="Gebruik"
                        filters={usageFilters}
                        selected={usageFilter}
                        onSelect={setUsageFilter}
                    />
                </div>

                {filteredItems.length > 0 ? (
                    <ul className="webstack-grid" aria-label="Webstack">
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
                    <p>Geen resultaten voor deze filters.</p>
                )}
            </div>
        </section>
    );
}