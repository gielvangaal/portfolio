import { useState } from "react";

import SectionHeading from "../../components/ui/SectionHeading";
import EducationItem from "./EducationItem";
import { useEducation } from "./useEducation";

import "./education.css";

export default function EducationSection() {
    const {
        data: educations = [],
        isLoading,
        isError,
    } = useEducation();

    const [openEducationId, setOpenEducationId] = useState(1);

    if (isLoading) {
        return <p>Education loading...</p>;
    }

    if (isError) {
        return <p>Education could not be loaded.</p>;
    }

    const handleToggle = (educationId) => {
        setOpenEducationId((currentId) =>
            currentId === educationId
                ? null
                : educationId
        );
    };

    return (
        <section
            id="education"
            className="education-section"
        >
            <SectionHeading as="h3">
                Onderwijs
            </SectionHeading>

            <div className="education-list">
                {educations.map((education) => (
                    <EducationItem
                        key={education.id}
                        education={education}
                        isOpen={openEducationId === education.id}
                        onToggle={() => handleToggle(education.id)}
                    />
                ))}
            </div>
        </section>
    );
}