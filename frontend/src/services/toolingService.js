import { toolingClient } from "../api/toolingClient";
import { mapTooling } from "../mappers/toolingMapper";

export const toolingService = {
    getAll: async () => {
        const data = await toolingClient.getAll();

        return data.map(mapTooling);
    },
};