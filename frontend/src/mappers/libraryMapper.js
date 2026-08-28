export function mapLibraryItem(data) {
    if (!data) {
        throw new Error("Library item data is missing");
    }

    return {
        id: data.id,
        title: data.title ?? "",
        creator: data.creator ?? "",
        type: data.type ?? "",

        media: data.media
            ? {
                path: data.media.path ?? "",
                altText: data.media.altText ?? "",
                type: data.media.type,
            }
            : null,

        technologies: (data.technologies ?? []).map(
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

        skills: (data.skills ?? []).map((skill) => ({
            id: skill.id,
            name: skill.name ?? "",
        })),

        tooling: (data.tooling ?? []).map((tool) => ({
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
    };
}