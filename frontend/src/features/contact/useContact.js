import { useQuery } from "@tanstack/react-query";

import { contactService } from "../../services/contactService";

export function useContact(language) {
    return useQuery({
        queryKey: ["contact", language],
        queryFn: () => contactService.getByLanguage(language),
    });
}