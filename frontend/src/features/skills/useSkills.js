import { useQuery } from "@tanstack/react-query";
import { skillService } from "../../services/skillService";

export function useSkills() {
    return useQuery({
        queryKey: ["skills"],
        queryFn: skillService.getAll,
    });
}