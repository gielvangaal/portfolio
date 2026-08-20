import { useQuery } from "@tanstack/react-query";
import { portfolioService } from "../../services/portfolioService";

export function usePortfolio(lang) {
    return useQuery({
        queryKey: ["portfolio", lang],
        queryFn: () => portfolioService.getAll(lang),
        enabled: Boolean(lang),
    });
}