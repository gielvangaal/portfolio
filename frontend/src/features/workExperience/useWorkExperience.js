import { useQuery } from "@tanstack/react-query";

import { fetchWorkExperiences } from "../../services/workExperienceService.js";

export function useWorkExperiences(lang = "nl") {
    return useQuery({
        queryKey: ["work-experiences", lang],
        queryFn: () => fetchWorkExperiences(lang),
    });
}