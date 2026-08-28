import { useQuery } from "@tanstack/react-query";
import { technologyService } from "../../services/technologyService";

export function useTechnologies() {
    return useQuery({
        queryKey: ["technologies"],
        queryFn: technologyService.getAll,
    });
}