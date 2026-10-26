import { httpClient } from "./httpClient";

export const skillClient = {
    getAll: async (lang = "nl") => {
        const response = await httpClient.get(
            `/api/skills?language=${lang}`
        );

        return response.data;
    },
};