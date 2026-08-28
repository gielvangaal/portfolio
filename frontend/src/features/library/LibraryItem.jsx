import PortfolioTag, {
    PortfolioTagType,
} from "../../components/ui/PortfolioTag";

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
                        <PortfolioTag
                            key={`technology-${technology.id}`}
                            type={PortfolioTagType.TECHNOLOGY}
                        >
                            {technology.name}
                        </PortfolioTag>
                    ))}

                    {item.skills.map((skill) => (
                        <PortfolioTag
                            key={`skill-${skill.id}`}
                            type={PortfolioTagType.SKILL}
                        >
                            {skill.name}
                        </PortfolioTag>
                    ))}

                    {item.tooling.map((tool) => (
                        <PortfolioTag
                            key={`tooling-${tool.id}`}
                            type={PortfolioTagType.TOOLING}
                        >
                            {tool.name}
                        </PortfolioTag>
                    ))}
                </div>
            </div>
        </article>
    );
}