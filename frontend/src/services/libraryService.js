import { libraryClient } from "../api/libraryClient";
import { mapLibraryItem } from "../mappers/libraryMapper";

export const libraryService = {
    getAll: async (lang) => {
        const data = await libraryClient.getAll(lang);

        return data.map(mapLibraryItem);
    },
};