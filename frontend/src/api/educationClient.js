import { httpClient, getMediaUrl } from "./httpClient";

export const educationClient = {
    getAll: async () => {
        const response = await httpClient.get(
            "/api/education"
        );

        return response.data.map((education) => ({
            ...education,

            organization: education.organization
                ? {
                    ...education.organization,

                    media: education.organization.media
                        ? {
                            ...education.organization.media,
                            path: getMediaUrl(
                                education.organization.media.path
                            ),
                        }
                        : null,
                }
                : null,

            sections: education.sections.map((section) => ({
                ...section,

                technologies: section.technologies.map(
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

                tooling: section.tooling.map((tool) => ({
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
            })),
        }));
    },
};