import { useState } from "react";

import Header from "../../components/ui/Header.jsx";

import LibraryItem from "./LibraryItem.jsx";
import { useLibrary } from "./useLibrary.js";

import "./library.css";
import Button from "../../components/ui/Button.jsx";

const INITIAL_VISIBLE_ITEMS = 4;
const FILTERS = [
    { value: "all", label: { nl: "Alles", en: "All" } },
    { value: "Book", label: { nl: "Boeken", en: "Books" } },
    { value: "Video", label: { nl: "Video", en: "Video" } },
    { value: "Music", label: { nl: "Muziek", en: "Music" } },
];

export default function LibrarySection({ lang = "nl" }) {
    const {
        data: libraryItems = [],
        isLoading,
        isError,
    } = useLibrary(lang);

    const [showAll, setShowAll] = useState(false);
    const [activeType, setActiveType] = useState("all");

    if (isLoading) {
        return <p>{lang === "en" ? "Loading bookshelf..." : "Boekenplank laden..."}</p>;
    }

    if (isError) {
        return <p>{lang === "en" ? "Bookshelf could not be loaded." : "Boekenplank kon niet worden geladen."}</p>;
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
                {lang === "en" ? "Bookshelf" : "Boekenplank"}
            </Header>

            <div className="library-filters" role="group" aria-label={lang === "en" ? "Filter bookshelf by category" : "Filter boekenplank op categorie"}>
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
                        {filter.label[lang] ?? filter.label.nl}
                    </button>
                ))}
            </div>

            <div id="library-items" className="library-list" aria-live="polite">
                {filteredItems.length === 0 && (
                    <p className="library-empty">{lang === "en" ? "No items in this category yet." : "Nog geen items in deze categorie."}</p>
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
                    {showAll ? (lang === "en" ? "Less" : "Minder") : (lang === "en" ? "More" : "Meer")}
                </Button>
            )}
        </section>
    );
}
