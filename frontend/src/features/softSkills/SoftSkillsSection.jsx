import { useSkills } from "../skills/useSkills.js";

import Header from "../../components/ui/Header.jsx";
import Badge from "../../components/ui/Badge.jsx";

import "./softskills.css";

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
            <Header as="h3">
                Softskills
            </Header>

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
                                        <Badge
                                            key={skill.id}
                                            variant="skill"
                                        >
                                            {skill.name}
                                        </Badge>
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