import { useState } from "react";

import Header from "../../components/ui/Header.jsx";

import LibraryItem from "./LibraryItem.jsx";
import { useLibrary } from "./useLibrary.js";

import "./library.css";
import Button from "../../components/ui/Button.jsx";

const INITIAL_VISIBLE_ITEMS = 4;
const FILTERS = [
    { value: "all", label: "Alles" },
    { value: "Book", label: "Boeken" },
    { value: "Video", label: "Video" },
    { value: "Music", label: "Muziek" },
];

export default function LibrarySection() {
    const {
        data: libraryItems = [],
        isLoading,
        isError,
    } = useLibrary();

    const [showAll, setShowAll] = useState(false);
    const [activeType, setActiveType] = useState("all");

    if (isLoading) {
        return <p>Library loading...</p>;
    }

    if (isError) {
        return <p>Library could not be loaded.</p>;
    }

    const filteredItems = activeType === "all"
        ? libraryItems
        : libraryItems.filter((item) => item.type === activeType);
    const visibleItems = showAll
        ? filteredItems
        : filteredItems.slice(0, INITIAL_VISIBLE_ITEMS);

    return (
        <section
            id="library"
            className="library-section"
        >
            <Header as="h3">
                Boekenplank
            </Header>

            <div className="library-filters" role="group" aria-label="Filter boekenplank op categorie">
                {FILTERS.map((filter) => (
                    <button
                        key={filter.value}
                        type="button"
                        className="library-filter"
                        aria-pressed={activeType === filter.value}
                        aria-controls="library-items"
                        onClick={() => {
                            setActiveType(filter.value);
                            setShowAll(false);
                        }}
                    >
                        {filter.label}
                    </button>
                ))}
            </div>

            <div id="library-items" className="library-list" aria-live="polite">
                {filteredItems.length === 0 && (
                    <p className="library-empty">Nog geen items in deze categorie.</p>
                )}
                {visibleItems.map((item) => (
                    <LibraryItem
                        key={item.id}
                        item={item}
                    />
                ))}
            </div>

            {filteredItems.length > INITIAL_VISIBLE_ITEMS && (
                <Button
                    type="button"
                    className="library-toggle"
                    onClick={() =>
                        setShowAll((current) => !current)
                    }
                    aria-expanded={showAll}
                    aria-controls="library-items"
                >
                    {showAll ? "Minder" : "Meer"}
                </Button>
            )}
        </section>
    );
}
