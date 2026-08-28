import { httpClient } from "./httpClient";

export const skillClient = {
    getAll: async () => {
        const response = await httpClient.get(
            "/api/skills"
        );

        return response.data;
    },
};