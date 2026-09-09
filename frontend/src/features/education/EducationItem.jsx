import TagGroups from "../../components/ui/TagGroups.jsx";

export default function EducationItem({ education }) {
    const period = education.endYear
        ? `${education.startYear} - ${education.endYear}`
        : `${education.startYear} - heden`;

    const organization = education.organization;
    const media = organization?.media;

    return (
        <div className="education-item">
            {media && (
                <div className="education-item__media">
                    <img
                        className="education-item__image"
                        src={media.path}
                        alt={media.altText}
                        loading="lazy"
                    />
                </div>
            )}

            <div className="education-item__content">
                <h3 className="education-item__title">
                    {education.program}
                    {organization?.name && (
                        <>
                            {" | "}
                            {organization.name}
                        </>
                    )}
                    {" | "}
                    {period}
                </h3>

                {education.sections.map((section) => (
                    <EducationSectionContent
                        key={section.id}
                        section={section}
                    />
                ))}

                {education.credentials.length > 0 && (
                    <div className="education-item__credentials">
                        {education.credentials.map((credential) => (
                            <CredentialItem
                                key={credential.id}
                                credential={credential}
                            />
                        ))}
                    </div>
                )}
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

            <TagGroups
                technologies={section.technologies}
                tooling={section.tooling}
                skills={section.skills}
                skillLimit={5}
                compact
            />
        </div>
    );
}

function CredentialItem({ credential }) {
    const url =
        credential.credentialUrl ??
        credential.documentUrl;

    return (
        <div className="education-item__credential">
            <span className="education-item__credential-type">
                {credential.type}
            </span>

            <span className="education-item__credential-name">
                {credential.name}
            </span>

            {credential.year && (
                <span className="education-item__credential-year">
                    {credential.year}
                </span>
            )}

            {url && (
                <a
                    className="education-item__credential-link"
                    href={url}
                    target="_blank"
                    rel="noreferrer"
                >
                    Bekijk ↗
                </a>
            )}
        </div>
    );
}