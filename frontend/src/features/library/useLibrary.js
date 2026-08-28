import { useQuery } from "@tanstack/react-query";

import { libraryService } from "../../services/libraryService";

export function useLibrary() {
    return useQuery({
        queryKey: ["library"],
        queryFn: libraryService.getAll,
    });
}