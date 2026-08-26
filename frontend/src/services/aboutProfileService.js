import { aboutProfileClient } from "../api/aboutProfileClient.js";
import { mapAboutProfile } from "../mappers/aboutProfileMapper.js";

export const aboutProfileService = {
    get: async (lang) => {
        const data = await aboutProfileClient.get(lang);

        return mapAboutProfile(data);
    },
};