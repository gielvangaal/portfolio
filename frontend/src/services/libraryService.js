import { libraryClient } from "../api/libraryClient";
import { mapLibraryItem } from "../mappers/libraryMapper";

export const libraryService = {
    getAll: async () => {
        const data = await libraryClient.getAll();

        return data.map(mapLibraryItem);
    },
};