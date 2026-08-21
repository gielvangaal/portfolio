import { useQuery } from "@tanstack/react-query";
import { portfolioService } from "../../services/portfolioService";

export function usePortfolioItem(slug, lang) {
    return useQuery({
        queryKey: ["portfolio", slug, lang],
        queryFn: () => portfolioService.getBySlug(slug, lang),
        enabled: Boolean(slug && lang),
    });
}