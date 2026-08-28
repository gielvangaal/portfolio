import { technologyClient } from "../api/technologyClient";
import { mapTechnology } from "../mappers/technologyMapper";

export const technologyService = {
    getAll: async () => {
        const data = await technologyClient.getAll();

        return data.map(mapTechnology);
    },
};