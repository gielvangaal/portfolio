import { portfolioClient } from "../api/portfolioClient";
import { mapPortfolioCard } from "../mappers/portfolioMapper";

export const portfolioService = {
    getAll: async (lang) => {
        const data = await portfolioClient.getAll(lang);

        return data.map(mapPortfolioCard);
    },
};