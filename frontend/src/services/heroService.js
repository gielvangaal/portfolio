import { heroClient } from "../api/heroClient.js";
import { mapHero } from "../mappers/heroMapper.js";

export const heroService = {
    get: async (lang) => {
        const data = await heroClient.get(lang);

        return mapHero(data);
    },
};