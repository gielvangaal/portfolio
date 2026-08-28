export function mapSkill(data) {
    if (!data) {
        throw new Error("Skill data is missing");
    }

    return {
        id: data.id,
        name: data.name ?? "",
        type: data.type ?? "",
    };
}