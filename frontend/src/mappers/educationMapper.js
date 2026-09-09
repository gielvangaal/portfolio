export function mapEducation(data) {
    if (!data) {
        throw new Error("Education data is missing");
    }

    return {
        id: data.id,
        program: data.program ?? "",
        startYear: data.startYear,
        endYear: data.endYear,

        organization: data.organization
            ? {
                id: data.organization.id,
                name: data.organization.name ?? "",
                type: data.organization.type ?? "",
                websiteUrl: data.organization.websiteUrl ?? null,

                media: data.organization.media
                    ? {
                        path: data.organization.media.path ?? "",
                        altText: data.organization.media.altText ?? "",
                        type: data.organization.media.type,
                    }
                    : null,
            }
            : null,

        credentials: (data.credentials ?? []).map((credential) => ({
            id: credential.id,
            name: credential.name ?? "",
            type: credential.type ?? "",
            status: credential.status ?? "",
            year: credential.year ?? null,
            credentialUrl: credential.credentialUrl ?? null,
            documentUrl: credential.documentUrl ?? null,
        })),

        sections: (data.sections ?? []).map((section) => ({
            id: section.id,
            title: section.title ?? null,

            technologies: (section.technologies ?? []).map(
                (technology) => ({
                    id: technology.id,
                    name: technology.name ?? "",
                    usage: technology.usage ?? "",

                    media: technology.media
                        ? {
                            path: technology.media.path ?? "",
                            altText: technology.media.altText ?? "",
                            type: technology.media.type,
                        }
                        : null,
                })
            ),

            skills: (section.skills ?? []).map((skill) => ({
                id: skill.id,
                name: skill.name ?? "",
            })),

            tooling: (section.tooling ?? []).map((tool) => ({
                id: tool.id,
                name: tool.name ?? "",

                media: tool.media
                    ? {
                        path: tool.media.path ?? "",
                        altText: tool.media.altText ?? "",
                        type: tool.media.type,
                    }
                    : null,
            })),
        })),
    };
}