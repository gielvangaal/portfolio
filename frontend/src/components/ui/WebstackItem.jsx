import "./webstackItem.css";

export default function WebstackItem({ item }) {
    return (
        <div className="webstack-item">
            <div className="webstack-item__media">
                {item.media && (
                    <img
                        src={item.media.path}
                        alt={item.media.altText ?? ""}
                        loading="lazy"
                    />
                )}
            </div>

            <span className="webstack-item__label">
                {item.type === "technology" ? "■ " : "◇ "}
                {item.name}
            </span>
        </div>
    );
}