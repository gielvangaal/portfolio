import { contactClient } from "../api/contactClient";
import { mapContact } from "../mappers/contactMapper";

export const contactService = {
    getByLanguage: async (language) => {
        const data = await contactClient.getByLanguage(language);

        return mapContact(data);
    },
};