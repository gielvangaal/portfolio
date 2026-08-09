import "./hero.css";
import {useHero} from "./useHero.js";

// --------------------------------------------------
// HERO SECTION
// --------------------------------------------------
export default function HeroSection({ lang }) {
    const {
        data: hero,
        isLoading,
        isError,
    } = useHero(lang);

    // --------------------------------------------------
    // QUERY STATE
    // --------------------------------------------------
    if (isLoading) {
        return <p>Hero laden...</p>;
    }

    if (isError) {
        return <p>Hero kon niet geladen worden.</p>;
    }

    // --------------------------------------------------
    // VIEW
    // --------------------------------------------------
    return (
        <section
            id="home"
            className="hero-section"
            aria-labelledby="hero-title"
        >
            <div className="hero">
                <div className="hero__purple" aria-hidden="true" />
                <div className="hero__yellow" aria-hidden="true" />

                <h1 id="hero-title" className="hero__title">
                    {hero.name}
                </h1>

                <div className="hero__role">
                    <h2>{hero.jobTitle}</h2>
                </div>

                <div
                    className="hero__circle"
                    role="img"
                    aria-label={hero.description}
                >
                    <svg viewBox="0 0 200 200">
                        <defs>
                            <path
                                id="hero-circle-path"
                                d="M 100, 100 m -80, 0 a 80,80 0 1,1 160,0 a 80,80 0 1,1 -160,0"
                            />
                        </defs>

                        <text>
                            <textPath
                                href="#hero-circle-path"
                                textLength="500"
                            >
                                {hero.description} &gt;&gt;&gt;&nbsp;
                            </textPath>
                        </text>
                    </svg>
                </div>

                <img
                    className="hero__image"
                    src={hero.mediaUrl}
                    alt={hero.description}
                />

                <p className="hero__tagline">
                    {hero.catchPhrase}
                </p>
            </div>
        </section>
    );
}