import { useQuery } from "@tanstack/react-query";

import { libraryService } from "../../services/libraryService";

export function useLibrary(lang = "nl") {
    return useQuery({
        queryKey: ["library", lang],
        queryFn: () => libraryService.getAll(lang),
    });
}