import { useSkills } from "../skills/useSkills.js";

import Header from "../../components/ui/Header.jsx";
import Badge from "../../components/ui/Badge.jsx";

import "./softskills.css";

const softSkillGroups = [
    {
        title: { nl: "Competenties", en: "Competencies" },
        keys: [
            "solution-oriented-thinking",
            "energy",
            "empathy",
            "creativity",
            "analytical-thinking",
            "independent-learning",
            "quality-awareness",
            "adaptability",
            "collaboration",
        ],
    },
    {
        title: { nl: "Vaardigheden", en: "Skills" },
        keys: [
            "practical-mindset",
            "interpersonal-skills",
            "independence",
            "accuracy-and-precision",
            "planning-and-organization",
            "effective-communication",
            "quick-learning-and-application",
            "clear-documentation",
        ],
    },
    {
        title: { nl: "Karakter", en: "Character" },
        keys: [
            "curious",
            "realistic",
            "customer-focused",
            "balanced",
            "spontaneous",
            "integrity",
            "creative",
            "committed",
            "decisive",
        ],
    },
];

export default function SoftSkillsSection({ lang = "nl" }) {
    const {
        data: skills = [],
        isLoading,
        isError,
    } = useSkills(lang);

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
                        const groupSkills = group.keys
                            .map((key) =>
                                skills.find((skill) => skill.key === key)
                            )
                            .filter(Boolean);

                        return (
                            <div
                                key={group.keys[0]}
                                className="softskills-group"
                            >
                                <h3 className="softskills-title">
                                    {group.title[lang] ?? group.title.nl}
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