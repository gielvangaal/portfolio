import { skillClient } from "../api/skillClient";
import { mapSkill } from "../mappers/skillMapper";

export const skillService = {
    getAll: async () => {
        const data = await skillClient.getAll();

        return data.map(mapSkill);
    },
};