import { useQuery } from "@tanstack/react-query";
import { heroService } from "../../services/heroService.js";

export function useHero(lang) {
    return useQuery({
        queryKey: ["hero", lang],
        queryFn: () => heroService.get(lang),
        enabled: Boolean(lang),
    });
}