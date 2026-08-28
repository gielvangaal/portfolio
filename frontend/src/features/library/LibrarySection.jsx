import { useState } from "react";

import SectionHeading from "../../components/ui/SectionHeading.jsx";

import LibraryItem from "./LibraryItem.jsx";
import { useLibrary } from "./useLibrary.js";

import "./library.css";

const INITIAL_VISIBLE_ITEMS = 4;

export default function LibrarySection() {
    const {
        data: libraryItems = [],
        isLoading,
        isError,
    } = useLibrary();

    const [showAll, setShowAll] = useState(false);

    if (isLoading) {
        return <p>Library loading...</p>;
    }

    if (isError) {
        return <p>Library could not be loaded.</p>;
    }

    const visibleItems = showAll
        ? libraryItems
        : libraryItems.slice(0, INITIAL_VISIBLE_ITEMS);

    return (
        <section
            id="library"
            className="library-section"
        >
            <SectionHeading as="h3">
                Boekenplank
            </SectionHeading>

            <div className="library-list">
                {visibleItems.map((item) => (
                    <LibraryItem
                        key={item.id}
                        item={item}
                    />
                ))}
            </div>

            {libraryItems.length > INITIAL_VISIBLE_ITEMS && (
                <button
                    type="button"
                    className="library-toggle"
                    onClick={() =>
                        setShowAll((current) => !current)
                    }
                    aria-expanded={showAll}
                >
                    {showAll ? "Minder" : "Meer"}
                </button>
            )}
        </section>
    );
}