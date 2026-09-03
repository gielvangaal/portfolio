import {
    FaGithub,
    FaInstagram,
    FaLinkedinIn,
    FaSpotify,
} from "react-icons/fa";

import {
    HiOutlineEnvelope,
    HiOutlineMapPin,
    HiOutlinePhone,
    HiOutlineUser,
} from "react-icons/hi2";

import Header from "../../components/ui/Header.jsx";
import { useContact } from "./useContact.js";

import "./contact.css";

export default function ContactSection({ language = "nl" }) {
    const {
        data: contact,
        isLoading,
        isError,
    } = useContact(language);

    if (isLoading) {
        return <p>Contact loading...</p>;
    }

    if (isError || !contact) {
        return <p>Contact could not be loaded.</p>;
    }

    return (
        <section
            id="contact"
            className="contact-section"
        >
            <div className="contact-section__details">
                <div className="contact-section__content">
                    <Header as="h2">
                        Contact
                    </Header>

                    <div className="contact-details">
                        <ContactRow
                            icon={<HiOutlineUser />}
                            value={contact.name}
                        />

                        <ContactRow
                            icon={<HiOutlinePhone />}
                            value={contact.phone}
                            href={`tel:${contact.phone}`}
                        />

                        <ContactRow
                            icon={<HiOutlineEnvelope />}
                            value={contact.email}
                            href={`mailto:${contact.email}`}
                        />

                        <ContactRow
                            icon={<HiOutlineMapPin />}
                            value={contact.location}
                        />
                    </div>
                </div>
            </div>

            <div className="contact-section__social">
                <div className="contact-socials">
                    <a
                        href={contact.githubUrl}
                        target="_blank"
                        rel="noreferrer"
                        aria-label="GitHub"
                    >
                        <FaGithub />
                    </a>

                    <a
                        href={contact.linkedInUrl}
                        target="_blank"
                        rel="noreferrer"
                        aria-label="LinkedIn"
                    >
                        <FaLinkedinIn />
                    </a>

                    <a
                        href={contact.instagramUrl}
                        target="_blank"
                        rel="noreferrer"
                        aria-label="Instagram"
                    >
                        <FaInstagram />
                    </a>

                    <a
                        href={contact.spotifyUrl}
                        target="_blank"
                        rel="noreferrer"
                        aria-label="Spotify"
                    >
                        <FaSpotify />
                    </a>
                </div>

                <p className="contact-credit">
                    {contact.creditText}
                </p>
            </div>
        </section>
    );
}

function ContactRow({
                        icon,
                        value,
                        href = null,
                    }) {
    const content = href
        ? (
            <a href={href}>
                {value}
            </a>
        )
        : value;

    return (
        <div className="contact-row">
            <span className="contact-row__icon">
                {icon}
            </span>

            <span className="contact-row__value">
                {content}
            </span>
        </div>
    );
}