export function mapWorkExperience(workExperience) {
    return {
        id: workExperience.id,
        company: workExperience.company,
        role: workExperience.role,
        startYear: workExperience.startYear,
        endYear: workExperience.endYear,
        media: workExperience.media,
        responsibilities: workExperience.responsibilities ?? [],
        technologies: workExperience.technologies ?? [],
        skills: workExperience.skills ?? [],
        tooling: workExperience.tooling ?? [],
    };
}