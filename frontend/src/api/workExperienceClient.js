import { httpClient, getMediaUrl } from "./httpClient";

export const workExperienceClient = {
    getAll: async () => {
        const response = await httpClient.get(
            "/api/work-experience"
        );

        return response.data.map((workExperience) => ({
            ...workExperience,

            media: workExperience.media
                ? {
                    ...workExperience.media,
                    path: getMediaUrl(
                        workExperience.media.path
                    ),
                }
                : null,

            technologies: workExperience.technologies.map(
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

            tooling: workExperience.tooling.map((tool) => ({
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