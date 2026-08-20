import axios from "axios";

const baseUrl = import.meta.env.VITE_API_BASE_URL;

export const httpClient = axios.create({
    baseURL: baseUrl,
    headers: {
        "Content-Type": "application/json",
    },
});

export function getMediaUrl(path) {
    return path ? `${baseUrl}${path}` : null;
}