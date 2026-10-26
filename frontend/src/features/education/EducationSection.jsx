import Header from "../../components/ui/Header.jsx";
import Accordion from "../../components/ui/Accordion.jsx";

import EducationItem from "./EducationItem.jsx";
import { useEducation } from "./useEducation.js";

import "./education.css";

export default function EducationSection({ lang = "nl" }) {
    const {
        data: educations = [],
        isLoading,
        isError,
    } = useEducation(lang);

    if (isLoading) {
        return <p>{lang === "en" ? "Loading education..." : "Opleidingen laden..."}</p>;
    }

    if (isError) {
        return <p>{lang === "en" ? "Education could not be loaded." : "Opleidingen konden niet worden geladen."}</p>;
    }

    const accordionItems = educations.map((education) => ({
        ...education,
        title: `${education.organization?.name ?? ""} | ${education.program}`,
    }));

    return (
        <section
            id="education"
            className="education-section"
        >
            <Header as="h3">
                {lang === "en" ? "Education" : "Onderwijs"}
            </Header>

            <div className="education-list">
                <Accordion
                    items={accordionItems}
                    defaultOpenId={accordionItems[1]?.id ?? null}
                    renderContent={(education) => (
                        <EducationItem education={education} lang={lang} />
                    )}
                />
            </div>
        </section>
    );
}