import { useWorkExperiences } from "./useWorkExperience.js";

import Accordion from "../../components/ui/Accordion.jsx";
import SectionHeading from "../../components/ui/SectionHeading.jsx";
import PortfolioTag from "../../components/ui/PortfolioTag.jsx";

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
            title: `${workExperience.company} | ${workExperience.role}`,
        })
    );

    return (
        <section
            id="werkervaring"
            className="work-experience-section"
        >
            <div className="work-experience-container">
                <SectionHeading as="h3">
                    Werkervaring
                </SectionHeading>

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
    return (
        <div className="work-experience-body">
            {workExperience.media && (
                <img
                    className="work-experience-logo"
                    src={workExperience.media.path}
                    alt={workExperience.media.altText}
                />
            )}

            <div className="work-experience-content">
                <h3 className="work-experience-title">
                    {workExperience.company}
                    {" | "}
                    {workExperience.role}
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

                <ul className="work-experience-responsibilities">
                    {workExperience.responsibilities.map(
                        (responsibility, index) => (
                            <li key={index}>
                                {responsibility}
                            </li>
                        )
                    )}
                </ul>

                <div className="work-experience-tags">
                    {workExperience.technologies.map(
                        (technology) => (
                            <PortfolioTag
                                key={`technology-${technology.id}`}
                                type="technology"
                            >
                                {technology.name}
                            </PortfolioTag>
                        )
                    )}

                    {workExperience.skills.map((skill) => (
                        <PortfolioTag
                            key={`skill-${skill.id}`}
                            type="skill"
                        >
                            {skill.name}
                        </PortfolioTag>
                    ))}

                    {workExperience.tooling.map((tool) => (
                        <PortfolioTag
                            key={`tooling-${tool.id}`}
                            type="tooling"
                        >
                            {tool.name}
                        </PortfolioTag>
                    ))}
                </div>
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