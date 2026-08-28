import { httpClient, getMediaUrl } from "./httpClient";

export const toolingClient = {
    getAll: async () => {
        const response = await httpClient.get(
            "/api/tooling"
        );

        return response.data.map((tooling) => ({
            ...tooling,
            media: tooling.media
                ? {
                    ...tooling.media,
                    path: getMediaUrl(tooling.media.path),
                }
                : null,
        }));
    },
};