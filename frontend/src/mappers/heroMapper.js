export function mapHero(data) {
    if (!data) {
        throw new Error("Hero data is missing");
    }

    return {
        name: data.name ?? "",
        jobTitle: data.jobTitle ?? "",
        description: data.description ?? "",
        mediaUrl: data.mediaUrl ?? "",
        catchPhrase: data.catchPhrase ?? "",
    };
}