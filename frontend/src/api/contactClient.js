import { httpClient } from "./httpClient";

export const contactClient = {
    getByLanguage: async (language) => {
        const response = await httpClient.get(
            `/api/contact/${language}`
        );

        return response.data;
    },
};