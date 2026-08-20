import { httpClient, getMediaUrl } from "./httpClient";

export const portfolioClient = {
    getAll: async (lang) => {
        const response = await httpClient.get(
            `/api/portfolio?language=${lang}`
        );

        return response.data.map((item) => ({
            ...item,
            primaryImageUrl: getMediaUrl(item.primaryImageUrl),
        }));
    },

    getBySlug: async (slug, lang) => {
        const response = await httpClient.get(
            `/api/portfolio/${slug}/${lang}`
        );

        return response.data;
    },
};