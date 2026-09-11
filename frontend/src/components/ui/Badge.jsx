import "./badge.css";

export const BadgeVariant = {
    TECHNOLOGY: "technology",
    SKILL: "skill",
    TOOLING: "tooling",
};

export default function Badge({
                                  children,
                                  variant,
                                  className = "",
                                  media = false,
                              }) {
    const badge = (
        <span className={`badge badge--${variant} ${className}`}>
            {children}
        </span>
    );

    if (!media) {
        return badge;
    }

    return (
        <span className="badge-with-media">
            <span className="badge-with-media__image">
                <img
                    src={media.path}
                    alt={media.altText ?? ""}
                    loading="lazy"
                />
            </span>

            {badge}
        </span>
    );
}