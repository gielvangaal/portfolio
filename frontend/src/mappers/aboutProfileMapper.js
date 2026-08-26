export function mapAboutProfile(data) {
    if (!data) {
        throw new Error("About profile data is missing");
    }

    return {
        description: data.description ?? "",
        imageUrl: data.imageUrl ?? "",
    };
}