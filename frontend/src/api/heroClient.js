import { httpClient } from "./httpClient";

export const heroClient = {
    get: async (lang) => {
        const response = await httpClient.get(`/api/Hero/${lang}`);
        return response.data;
    },
};