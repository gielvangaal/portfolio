export function mapTechnology(data) {
    if (!data) {
        throw new Error("Technology data is missing");
    }

    return {
        id: data.id,
        name: data.name ?? "",
        usage: data.usage ?? "",
        media: data.media
            ? {
                path: data.media.path ?? "",
                altText: data.media.altText ?? "",
                type: data.media.type,
            }
            : null,
    };
}