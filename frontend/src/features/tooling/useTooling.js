import { useQuery } from "@tanstack/react-query";
import { toolingService } from "../../services/toolingService";

export function useTooling() {
    return useQuery({
        queryKey: ["tooling"],
        queryFn: toolingService.getAll,
    });
}