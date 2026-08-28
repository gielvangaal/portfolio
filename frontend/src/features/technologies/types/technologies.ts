export interface MediaResponse {
    path: string;
    altText: string;
    type: number;
}

export interface TechnologyResponse {
    id: number;
    name: string;
    usage: string;
    media: MediaResponse | null;
}

export type TechnologyUsage =
    | "Daily"
    | "Regular"
    | "Occasional"
    | "Past";