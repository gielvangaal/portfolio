import { educationClient } from "../api/educationClient";
import { mapEducation } from "../mappers/educationMapper";

export const educationService = {
    getAll: async (lang) => {
        const data = await educationClient.getAll(lang);

        return data.map(mapEducation);
    },
};