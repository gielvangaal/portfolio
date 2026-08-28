export function mapContact(data) {
    if (!data) {
        throw new Error("Contact data is missing");
    }

    return {
        name: data.name ?? "",
        phone: data.phone ?? "",
        email: data.email ?? "",
        location: data.location ?? "",
        githubUrl: data.githubUrl ?? "",
        linkedInUrl: data.linkedInUrl ?? "",
        instagramUrl: data.instagramUrl ?? "",
        spotifyUrl: data.spotifyUrl ?? "",
        creditText: data.creditText ?? "",
    };
}