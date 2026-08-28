export function mapEducation(data) {
    if (!data) {
        throw new Error("Education data is missing");
    }

    return {
        id: data.id,
        institution: data.institution ?? "",
        program: data.program ?? "",
        startYear: data.startYear,
        endYear: data.endYear,

        media: data.media
            ? {
                path: data.media.path ?? "",
                altText: data.media.altText ?? "",
                type: data.media.type,
            }
            : null,

        sections: (data.sections ?? []).map((section) => ({
            id: section.id,
            title: section.title ?? null,

            technologies: (section.technologies ?? []).map((technology) => ({
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
            })),

            topics: (section.topics ?? []).map((topic) => ({
                id: topic.id,
                name: topic.name ?? "",
            })),
        })),
    };
}