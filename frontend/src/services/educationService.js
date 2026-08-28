import { educationClient } from "../api/educationClient";
import { mapEducation } from "../mappers/educationMapper";

export const educationService = {
    getAll: async () => {
        const data = await educationClient.getAll();

        return data.map(mapEducation);
    },
};