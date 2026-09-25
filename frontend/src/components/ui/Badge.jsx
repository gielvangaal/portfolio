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
                              }) {
    return (
        <span className={`badge badge--${variant} ${className}`}>
            {children}
        </span>
    );
}