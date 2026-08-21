import { portfolioClient } from "../api/portfolioClient";
import {
    mapPortfolioCard,
    mapPortfolioDetail,
} from "../mappers/portfolioMapper";

export const portfolioService = {
    getAll: async (lang) => {
        const data = await portfolioClient.getAll(lang);

        return data.map(mapPortfolioCard);
    },

    getBySlug: async (slug, lang) => {
        const data = await portfolioClient.getBySlug(slug, lang);

        return mapPortfolioDetail(data);
    },
};