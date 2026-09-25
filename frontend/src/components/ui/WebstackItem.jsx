import "./webstackItem.css";

export default function WebstackItem({ item }) {
    return (
        <div
            className={`webstack-item webstack-item--${item.type}`}
        >
            <div className="webstack-item__media">
                {item.media && (
                    <img
                        src={item.media.path}
                        alt={item.media.altText ?? ""}
                        loading="lazy"
                    />
                )}
            </div>

            <div className="webstack-item__label">
                <span className="webstack-item__marker" />
                <span>{item.name}</span>
            </div>
        </div>
    );
}