export function mapWorkExperience(workExperience) {
    if (!workExperience) {
        throw new Error("Work experience data is missing");
    }

    return {
        id: workExperience.id,
        role: workExperience.role ?? "",
        startYear: workExperience.startYear,
        endYear: workExperience.endYear,

        organization: workExperience.organization
            ? {
                id: workExperience.organization.id,
                name: workExperience.organization.name ?? "",
                type: workExperience.organization.type ?? "",
                websiteUrl:
                    workExperience.organization.websiteUrl ?? null,

                media: workExperience.organization.media
                    ? {
                        path:
                            workExperience.organization.media.path ?? "",
                        altText:
                            workExperience.organization.media.altText ?? "",
                        type:
                        workExperience.organization.media.type,
                    }
                    : null,
            }
            : null,

        responsibilities:
            workExperience.responsibilities ?? [],

        technologies:
            workExperience.technologies ?? [],

        skills:
            workExperience.skills ?? [],

        tooling:
            workExperience.tooling ?? [],
    };
}