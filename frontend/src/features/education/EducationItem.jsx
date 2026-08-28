import PortfolioTag, {
    PortfolioTagType,
} from "../../components/ui/PortfolioTag";

export default function EducationItem({
                                          education,
                                          isOpen,
                                          onToggle,
                                      }) {
    const contentId = `education-content-${education.id}`;

    const period = education.endYear
        ? `${education.startYear} - ${education.endYear}`
        : `${education.startYear} - heden`;

    return (
        <article className="education-item">
            <header className="education-item__header">
                <button
                    type="button"
                    className="education-item__button"
                    aria-expanded={isOpen}
                    aria-controls={contentId}
                    onClick={onToggle}
                >
                    <span>
                        {education.institution} | {education.program}
                    </span>

                    <span
                        className="education-item__indicator"
                        aria-hidden="true"
                    >
                        {isOpen ? "−" : "+"}
                    </span>
                </button>
            </header>

            {isOpen && (
                <div
                    id={contentId}
                    className="education-item__collapse"
                >
                    <div className="education-item__body">
                        {education.media && (
                            <img
                                className="education-item__image"
                                src={education.media.path}
                                alt={education.media.altText}
                                loading="lazy"
                            />
                        )}

                        <div className="education-item__content">
                            <h3>
                                {education.program}
                                {" | "}
                                {education.institution}
                                {" | "}
                                {period}
                            </h3>

                            {education.sections.map((section) => (
                                <EducationSectionContent
                                    key={section.id}
                                    section={section}
                                />
                            ))}
                        </div>
                    </div>
                </div>
            )}
        </article>
    );
}

function EducationSectionContent({ section }) {
    return (
        <div className="education-item__section">
            {section.title && (
                <h4>{section.title}</h4>
            )}

            <div className="education-item__tags">
                {section.technologies.map((technology) => (
                    <PortfolioTag
                        key={`technology-${technology.id}`}
                        type={PortfolioTagType.TECHNOLOGY}
                    >
                        {technology.name}
                    </PortfolioTag>
                ))}

                {section.skills.map((skill) => (
                    <PortfolioTag
                        key={`skill-${skill.id}`}
                        type={PortfolioTagType.SKILL}
                    >
                        {skill.name}
                    </PortfolioTag>
                ))}

                {section.tooling.map((tool) => (
                    <PortfolioTag
                        key={`tooling-${tool.id}`}
                        type={PortfolioTagType.TOOLING}
                    >
                        {tool.name}
                    </PortfolioTag>
                ))}
            </div>
        </div>
    );
}