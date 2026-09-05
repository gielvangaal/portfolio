import { useState } from "react";

import Badge, {
    BadgeVariant,
} from "./Badge.jsx";

import "./tagGroups.css";

export default function TagGroups({
                                      technologies = [],
                                      tooling = [],
                                      skills = [],

                                      technologyLimit = null,
                                      toolingLimit = null,
                                      skillLimit = 5,

                                      compact = false,
                                  }) {
    if (compact) {
        return (
            <CompactTagGroups
                technologies={technologies}
                tooling={tooling}
                skills={skills}
                technologyLimit={technologyLimit}
                toolingLimit={toolingLimit}
                skillLimit={skillLimit}
            />
        );
    }

    return (
        <div className="tag-groups">
            <TagGroup
                label="Technologie"
                items={technologies}
                variant={BadgeVariant.TECHNOLOGY}
                limit={technologyLimit}
            />

            <TagGroup
                label="Tooling"
                items={tooling}
                variant={BadgeVariant.TOOLING}
                limit={toolingLimit}
            />

            <TagGroup
                label="Vaardigheden"
                items={skills}
                variant={BadgeVariant.SKILL}
                limit={skillLimit}
            />
        </div>
    );
}

function CompactTagGroups({
                              technologies,
                              tooling,
                              skills,
                              technologyLimit,
                              toolingLimit,
                              skillLimit,
                          }) {
    const [showAll, setShowAll] = useState(false);

    const visibleTechnologies = getVisibleItems(
        technologies,
        technologyLimit,
        showAll
    );

    const visibleTooling = getVisibleItems(
        tooling,
        toolingLimit,
        showAll
    );

    const visibleSkills = getVisibleItems(
        skills,
        skillLimit,
        showAll
    );

    const hiddenCount =
        getHiddenCount(technologies, technologyLimit) +
        getHiddenCount(tooling, toolingLimit) +
        getHiddenCount(skills, skillLimit);

    const hasMore = hiddenCount > 0;

    return (
        <div className="tag-groups tag-groups--compact">
            <ul className="tag-groups__items">
                {visibleTechnologies.map((item) => (
                    <TagItem
                        key={getItemKey(item, "technology")}
                        item={item}
                        variant={BadgeVariant.TECHNOLOGY}
                    />
                ))}

                {visibleTooling.map((item) => (
                    <TagItem
                        key={getItemKey(item, "tooling")}
                        item={item}
                        variant={BadgeVariant.TOOLING}
                    />
                ))}

                {visibleSkills.map((item) => (
                    <TagItem
                        key={getItemKey(item, "skill")}
                        item={item}
                        variant={BadgeVariant.SKILL}
                    />
                ))}
            </ul>

            {hasMore && (
                <button
                    type="button"
                    className="tag-groups__toggle"
                    onClick={() => setShowAll((current) => !current)}
                >
                    {showAll
                        ? "Minder tonen"
                        : `+ ${hiddenCount} meer`}
                </button>
            )}
        </div>
    );
}

function TagGroup({
                      label,
                      items = [],
                      variant,
                      limit,
                  }) {
    const [showAll, setShowAll] = useState(false);

    if (items.length === 0) {
        return null;
    }

    const visibleItems = getVisibleItems(
        items,
        limit,
        showAll
    );

    const hiddenCount = getHiddenCount(
        items,
        limit,
        showAll
    );

    return (
        <div className="tag-groups__group">
            <p className="tag-groups__label">
                {label}
            </p>

            <ul className="tag-groups__items">
                {visibleItems.map((item) => (
                    <TagItem
                        key={getItemKey(item, label)}
                        item={item}
                        variant={variant}
                    />
                ))}
            </ul>

            {(hiddenCount > 0 || showAll) && (
                <button
                    type="button"
                    className="tag-groups__toggle"
                    onClick={() =>
                        setShowAll((current) => !current)
                    }
                >
                    {showAll
                        ? "Minder tonen"
                        : `+ ${hiddenCount} meer`}
                </button>
            )}
        </div>
    );
}

function TagItem({ item, variant }) {
    const name =
        typeof item === "string"
            ? item
            : item.name;

    return (
        <li>
            <Badge variant={variant}>
                {name}
            </Badge>
        </li>
    );
}

function getVisibleItems(items, limit, showAll) {
    if (
        showAll ||
        limit === null ||
        limit === undefined
    ) {
        return items;
    }

    return items.slice(0, limit);
}

function getHiddenCount(items, limit, showAll) {
    if (
        showAll ||
        limit === null ||
        limit === undefined
    ) {
        return 0;
    }

    return Math.max(
        0,
        items.length - limit
    );
}

function getItemKey(item, prefix) {
    if (typeof item === "string") {
        return `${prefix}-${item}`;
    }

    return `${prefix}-${item.id}`;
}