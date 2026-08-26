import { httpClient, getMediaUrl } from "./httpClient";

export const aboutProfileClient = {
    get: async (lang) => {
        const response = await httpClient.get(`/api/about/${lang}`);

        return {
            ...response.data,
            imageUrl: getMediaUrl(response.data.imagePath),
        };
    },
};