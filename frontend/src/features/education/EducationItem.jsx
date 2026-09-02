import Badge, {
    BadgeVariant,
} from "../../components/ui/Badge.jsx";

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
                    <Badge
                        key={`technology-${technology.id}`}
                        variant={BadgeVariant.TECHNOLOGY}
                    >
                        {technology.name}
                    </Badge>
                ))}

                {section.skills.map((skill) => (
                    <Badge
                        key={`skill-${skill.id}`}
                        variant={BadgeVariant.SKILL}
                    >
                        {skill.name}
                    </Badge>
                ))}

                {section.tooling.map((tool) => (
                    <Badge
                        key={`tooling-${tool.id}`}
                        variant={BadgeVariant.TOOLING}
                    >
                        {tool.name}
                    </Badge>
                ))}
            </div>
        </div>
    );
}