import { httpClient, getMediaUrl } from "./httpClient";

export const educationClient = {
    getAll: async () => {
        const response = await httpClient.get(
            "/api/education"
        );

        return response.data.map((education) => ({
            ...education,

            media: education.media
                ? {
                    ...education.media,
                    path: getMediaUrl(education.media.path),
                }
                : null,

            sections: education.sections.map((section) => ({
                ...section,

                technologies: section.technologies.map((technology) => ({
                    ...technology,

                    media: technology.media
                        ? {
                            ...technology.media,
                            path: getMediaUrl(technology.media.path),
                        }
                        : null,
                })),
            })),
        }));
    },
};