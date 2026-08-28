import { useQuery } from "@tanstack/react-query";

import { fetchWorkExperiences } from "../../services/workExperienceService.js";

export function useWorkExperiences() {
    return useQuery({
        queryKey: ["work-experiences"],
        queryFn: fetchWorkExperiences,
    });
}