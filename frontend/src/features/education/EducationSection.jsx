import Header from "../../components/ui/Header.jsx";
import Accordion from "../../components/ui/Accordion.jsx";

import EducationItem from "./EducationItem.jsx";
import { useEducation } from "./useEducation.js";

import "./education.css";

export default function EducationSection() {
    const {
        data: educations = [],
        isLoading,
        isError,
    } = useEducation();

    if (isLoading) {
        return <p>Education loading...</p>;
    }

    if (isError) {
        return <p>Education could not be loaded.</p>;
    }

    const accordionItems = educations.map((education) => ({
        ...education,
        title: `${education.institution} | ${education.program}`,
    }));

    return (
        <section
            id="education"
            className="education-section"
        >
            <Header as="h3">
                Onderwijs
            </Header>

            <div className="education-list">
                <Accordion
                    items={accordionItems}
                    defaultOpenId={accordionItems[0]?.id ?? null}
                    renderContent={(education) => (
                        <EducationItem
                            education={education}
                        />
                    )}
                />
            </div>
        </section>
    );
}