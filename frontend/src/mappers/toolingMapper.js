export function mapTooling(data) {
    if (!data) {
        throw new Error("Tooling data is missing");
    }

    return {
        id: data.id,
        name: data.name ?? "",
        media: data.media
            ? {
                path: data.media.path ?? "",
                altText: data.media.altText ?? "",
                type: data.media.type,
            }
            : null,
    };
}