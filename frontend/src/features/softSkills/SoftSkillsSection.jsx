import { useSkills } from "../skills/useSkills.js";

import SectionHeading from "../../components/ui/SectionHeading.jsx";

import "./softskills.css";
import PortfolioTag from "../../components/ui/PortfolioTag.jsx";

const softSkillGroups = [
    {
        title: "Vaardigheden",
        names: [
            "Praktische instelling",
            "Sociale vaardigheden",
            "Zelfstandigheid",
            "Nauwkeurig en exact",
            "Plannen en structureren",
            "Effectief communiceren",
            "Snel leren en toepassen",
            "Helder documenteren",
        ],
    },
    {
        title: "Competenties",
        names: [
            "Oplossingsgericht denken",
            "Energie",
            "Empathie",
            "Creativiteit",
            "Analytisch vermogen",
            "Zelfstandig leren",
            "Kwaliteitsbewustzijn",
            "Flexibiliteit",
            "Samenwerken",
        ],
    },
    {
        title: "Karakter",
        names: [
            "Nieuwsgierig",
            "Realistisch",
            "Klantgericht",
            "Evenwichtig",
            "Spontaan",
            "Integer",
            "Creatief",
            "Betrokken",
            "Doortastend",
        ],
    },
];

export default function SoftSkillsSection() {
    const {
        data: skills = [],
        isLoading,
        isError,
    } = useSkills();

    if (isLoading || isError) {
        return null;
    }

    return (
        <section
            id="softskills"
            className="softskills-section"
        >
            <SectionHeading as="h3">
                Softskills
            </SectionHeading>

            <div className="softskills-container">

                <div className="softskills-groups">
                    {softSkillGroups.map((group) => {
                        const groupSkills = group.names
                            .map((name) =>
                                skills.find((skill) => skill.name === name)
                            )
                            .filter(Boolean);

                        return (
                            <div
                                key={group.title}
                                className="softskills-group"
                            >
                                <h3 className="softskills-title">
                                    {group.title}
                                </h3>

                                <div className="softskills-list">
                                    {groupSkills.map((skill) => (
                                        <PortfolioTag
                                            key={skill.id}
                                            type="skill"
                                        >
                                            {skill.name}
                                        </PortfolioTag>
                                    ))}
                                </div>
                            </div>
                        );
                    })}
                </div>
            </div>
        </section>
    );
}