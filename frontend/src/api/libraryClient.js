import { httpClient, getMediaUrl } from "./httpClient";

export const libraryClient = {
    getAll: async () => {
        const response = await httpClient.get(
            "/api/library"
        );

        return response.data.map((item) => ({
            ...item,

            media: item.media
                ? {
                    ...item.media,
                    path: getMediaUrl(item.media.path),
                }
                : null,

            technologies: item.technologies.map(
                (technology) => ({
                    ...technology,

                    media: technology.media
                        ? {
                            ...technology.media,
                            path: getMediaUrl(
                                technology.media.path
                            ),
                        }
                        : null,
                })
            ),

            tooling: item.tooling.map((tool) => ({
                ...tool,

                media: tool.media
                    ? {
                        ...tool.media,
                        path: getMediaUrl(
                            tool.media.path
                        ),
                    }
                    : null,
            })),
        }));
    },
};