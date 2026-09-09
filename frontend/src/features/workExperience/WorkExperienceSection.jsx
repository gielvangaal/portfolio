import { useWorkExperiences } from "./useWorkExperience.js";

import Accordion from "../../components/ui/Accordion.jsx";
import Header from "../../components/ui/Header.jsx";
import TagGroups from "../../components/ui/TagGroups.jsx";

import "./workExperience.css";

export default function WorkExperienceSection() {
    const {
        data: workExperiences = [],
        isLoading,
        isError,
    } = useWorkExperiences();

    if (isLoading || isError) {
        return null;
    }

    const accordionItems = workExperiences.map(
        (workExperience) => ({
            ...workExperience,
            title: `${workExperience.organization?.name ?? ""} | ${workExperience.role}`,
        })
    );

    return (
        <section
            id="werkervaring"
            className="work-experience-section"
        >
            <div className="work-experience-container">
                <Header as="h3">
                    Werkervaring
                </Header>

                <div className="work-experience-accordion">
                    <Accordion
                        items={accordionItems}
                        defaultOpenId={
                            accordionItems[0]?.id ?? null
                        }
                        renderContent={(workExperience) => (
                            <WorkExperienceContent
                                workExperience={workExperience}
                            />
                        )}
                    />
                </div>
            </div>
        </section>
    );
}

function WorkExperienceContent({ workExperience }) {
    const organization = workExperience.organization;
    const media = organization?.media;

    return (
        <div className="work-experience-body">
            {media && (
                <div className="work-experience-media">
                    <img
                        className="work-experience-logo"
                        src={media.path}
                        alt={media.altText}
                        loading="lazy"
                    />
                </div>
            )}

            <div className="work-experience-content">
                <h3 className="work-experience-title">
                    {workExperience.role}

                    {organization?.name && (
                        <>
                            {" | "}
                            {organization.name}
                        </>
                    )}
                </h3>

                {(workExperience.startYear ||
                    workExperience.endYear) && (
                    <p className="work-experience-period">
                        {formatPeriod(
                            workExperience.startYear,
                            workExperience.endYear
                        )}
                    </p>
                )}

                {workExperience.responsibilities.length > 0 && (
                    <ul className="work-experience-responsibilities">
                        {workExperience.responsibilities.map(
                            (responsibility, index) => (
                                <li key={index}>
                                    {responsibility}
                                </li>
                            )
                        )}
                    </ul>
                )}

                <TagGroups
                    technologies={workExperience.technologies}
                    tooling={workExperience.tooling}
                    skills={workExperience.skills}
                    technologyLimit={5}
                    toolingLimit={5}
                    skillLimit={5}
                    compact
                />
            </div>
        </div>
    );
}

function formatPeriod(startYear, endYear) {
    if (startYear && endYear) {
        return `${startYear} – ${endYear}`;
    }

    if (startYear) {
        return `${startYear} – heden`;
    }

    return endYear?.toString() ?? "";
}