import { useQuery } from "@tanstack/react-query";

import { educationService } from "../../services/educationService";

export function useEducation() {
    return useQuery({
        queryKey: ["education"],
        queryFn: educationService.getAll,
    });
}