import Badge, {
    BadgeVariant,
} from "../../components/ui/Badge.jsx";

export default function LibraryItem({ item }) {
    return (
        <article className="library-item">
            {item.media && (
                <img
                    className="library-item__image"
                    src={item.media.path}
                    alt={item.media.altText}
                    loading="lazy"
                />
            )}

            <div className="library-item__content">
                <div className="library-item__info">
                    <h4 className="library-item__title">
                        {item.title}
                    </h4>

                    <p className="library-item__creator">
                        {item.creator}
                    </p>
                </div>

                <div className="library-item__tags">
                    {item.technologies.map((technology) => (
                        <Badge
                            key={`technology-${technology.id}`}
                            variant={BadgeVariant.TECHNOLOGY}
                        >
                            {technology.name}
                        </Badge>
                    ))}

                    {item.skills.map((skill) => (
                        <Badge
                            key={`skill-${skill.id}`}
                            variant={BadgeVariant.SKILL}
                        >
                            {skill.name}
                        </Badge>
                    ))}

                    {item.tooling.map((tool) => (
                        <Badge
                            key={`tooling-${tool.id}`}
                            variant={BadgeVariant.TOOLING}
                        >
                            {tool.name}
                        </Badge>
                    ))}
                </div>
            </div>
        </article>
    );
}