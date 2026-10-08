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

            </div>
        </article>
    );
}
