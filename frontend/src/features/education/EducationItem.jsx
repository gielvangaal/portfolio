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
                                {education.program} | {education.institution} | {period}
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
    const items = [
        ...section.technologies.map((technology) => ({
            key: `technology-${technology.id}`,
            name: technology.name,
        })),

        ...section.topics.map((topic) => ({
            key: `topic-${topic.id}`,
            name: topic.name,
        })),
    ];

    return (
        <div className="education-item__section">
            {section.title && (
                <h4>{section.title}</h4>
            )}

            <ul className="education-item__topics">
                {items.map((item) => (
                    <li key={item.key}>
                        {item.name}
                    </li>
                ))}
            </ul>
        </div>
    );
}