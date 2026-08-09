import { useQuery } from "@tanstack/react-query";
import { heroClient } from "../../api/heroClient";

export function useHero(lang) {
    return useQuery({
        queryKey: ["hero", lang],
        queryFn: () => heroClient.get(lang),
        enabled: Boolean(lang),
    });
}