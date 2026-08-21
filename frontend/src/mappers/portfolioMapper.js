export function mapPortfolioCard(data) {
    if (!data) {
        throw new Error("Portfolio card data is missing");
    }

    return {
        slug: data.slug ?? "",
        title: data.title ?? "",
        cardDescription: data.cardDescription ?? "",
        projectDate: data.projectDate ?? "",
        projectType: data.projectType ?? "",
        role: data.role ?? "",
        categories: data.categories ?? [],
        technologies: data.technologies ?? [],
        primaryImageUrl: data.primaryImageUrl ?? "",
    };
}

export function mapPortfolioDetail(data) {
    if (!data) {
        throw new Error("Portfolio detail data is missing");
    }

    return {
        slug: data.slug ?? "",
        title: data.title ?? "",
        cardDescription: data.cardDescription ?? "",
        description: data.description ?? "",
        projectDate: data.projectDate ?? "",
        projectType: data.projectType ?? "",
        role: data.role ?? "",
        teamSize: data.teamSize ?? null,
        duration: data.duration ?? null,
        gitHubUrl: data.gitHubUrl ?? null,
        liveSiteUrl: data.liveSiteUrl ?? null,
        categories: data.categories ?? [],
        technologies: data.technologies ?? [],
        media: data.media ?? [],
    };
}