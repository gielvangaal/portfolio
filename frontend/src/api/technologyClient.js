import { httpClient, getMediaUrl } from "./httpClient";

export const technologyClient = {
    getAll: async () => {
        const response = await httpClient.get(
            "/api/technologies"
        );

        return response.data.map((technology) => ({
            ...technology,
            media: technology.media
                ? {
                    ...technology.media,
                    path: getMediaUrl(technology.media.path),
                }
                : null,
        }));
    },
};