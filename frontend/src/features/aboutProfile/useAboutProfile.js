import { useQuery } from "@tanstack/react-query";
import { aboutProfileService } from "../../services/aboutProfileService.js";

export function useAboutProfile(lang) {
    return useQuery({
        queryKey: ["aboutProfile", lang],
        queryFn: () => aboutProfileService.get(lang),
        enabled: Boolean(lang),
    });
}