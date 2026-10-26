import { useQuery } from "@tanstack/react-query";
import { educationService } from "../../services/educationService";

export function useEducation(lang) {
    return useQuery({
        queryKey: ["education", lang],
        queryFn: () => educationService.getAll(lang),
    });
}