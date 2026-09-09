import { httpClient, getMediaUrl } from "./httpClient";

export const workExperienceClient = {
    getAll: async () => {
        const response = await httpClient.get(
            "/api/work-experience"
        );

        return response.data.map((workExperience) => ({
            ...workExperience,

            organization: workExperience.organization
                ? {
                    ...workExperience.organization,

                    media: workExperience.organization.media
                        ? {
                            ...workExperience.organization.media,
                            path: getMediaUrl(
                                workExperience.organization.media.path
                            ),
                        }
                        : null,
                }
                : null,

            technologies: (workExperience.technologies ?? []).map(
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

            tooling: (workExperience.tooling ?? []).map((tool) => ({
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