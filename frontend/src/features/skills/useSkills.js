import { useQuery } from "@tanstack/react-query";
import { skillService } from "../../services/skillService";

export function useSkills(lang = "nl") {
    return useQuery({
        queryKey: ["skills", lang],
        queryFn: () => skillService.getAll(lang),
    });
}