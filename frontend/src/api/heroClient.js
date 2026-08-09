import { httpClient } from "./httpClient";

export const heroClient = {
    get: async (lang) => {
        const response = await httpClient.get(`/api/Hero/${lang}`);

        return {
            ...response.data,
            mediaUrl: `${import.meta.env.VITE_API_BASE_URL}${response.data.mediaPath}`,
        };
    },
};