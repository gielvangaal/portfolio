import ReactMarkdown from "react-markdown";

import SectionHeading from "../../components/ui/SectionHeading";
import { useAboutProfile } from "./useAboutProfile";

import "./aboutProfile.css";

export default function AboutProfileSection({ lang }) {
    const {
        data: aboutProfile,
        isLoading,
        isError,
    } = useAboutProfile(lang);

    if (isLoading) {
        return <p>About profile loading...</p>;
    }

    if (isError) {
        return <p>About profile could not be loaded.</p>;
    }

    return (
        <section id="about" className="about-profile-section">
            <SectionHeading>
                {lang === "nl" ? "Over mij" : "About me"}
            </SectionHeading>

            <article className="about-profile">
                <img
                    className="about-profile__image"
                    src={aboutProfile.imageUrl}
                    alt=""
                    loading="lazy"
                />

                <div className="about-profile__description">
                    <ReactMarkdown>
                        {aboutProfile.description}
                    </ReactMarkdown>
                </div>
            </article>
        </section>
    );
}