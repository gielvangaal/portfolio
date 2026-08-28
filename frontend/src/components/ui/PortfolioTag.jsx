import "./portfolioTag.css";

export const PortfolioTagType = {
    TECHNOLOGY: "technology",
    SKILL: "skill",
    TOOLING: "tooling",
};

export default function PortfolioTag({
                                         children,
                                         type,
                                     }) {
    return (
        <span
            className={`portfolio-tag portfolio-tag--${type}`}
        >
            {children}
        </span>
    );
}