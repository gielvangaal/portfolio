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