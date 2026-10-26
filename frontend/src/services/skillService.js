import { skillClient } from "../api/skillClient";
import { mapSkill } from "../mappers/skillMapper";

export const skillService = {
    getAll: async (lang) => {
        const data = await skillClient.getAll(lang);

        return data.map(mapSkill);
    },
};