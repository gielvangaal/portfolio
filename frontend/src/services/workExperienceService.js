import { workExperienceClient } from "../api/workExperienceClient.js";
import { mapWorkExperience } from "../mappers/workExperienceMapper.js";

export async function fetchWorkExperiences(lang) {
    const workExperiences = await workExperienceClient.getAll(lang);

    return workExperiences.map(mapWorkExperience);
}