import PortfolioTag, {
    PortfolioTagType,
} from "../../components/ui/PortfolioTag";

export default function EducationItem({ education }) {
    const period = education.endYear
        ? `${education.startYear} - ${education.endYear}`
        : `${education.startYear} - heden`;

    return (
        <div className="education-item">
            {education.media && (
                <div className="education-item__media">
                    <img
                        className="education-item__image"
                        src={education.media.path}
                        alt={education.media.altText}
                        loading="lazy"
                    />
                </div>
            )}

            <div className="education-item__content">
                <h3 className="education-item__title">
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
    );
}

function EducationSectionContent({ section }) {
    return (
        <div className="education-item__section">
            {section.title && (
                <h4 className="education-item__section-title">
                    {section.title}
                </h4>
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