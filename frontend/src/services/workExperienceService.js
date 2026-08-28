import { workExperienceClient } from "../api/workExperienceClient.js";
import { mapWorkExperience } from "../mappers/workExperienceMapper.js";

export async function fetchWorkExperiences() {
    const workExperiences = await workExperienceClient.getAll();

    return workExperiences.map(mapWorkExperience);
}