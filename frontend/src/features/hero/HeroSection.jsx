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
        return <p>Hero loading 1-2-3...</p>;
    }

    if (isError) {
        return <p>Whoops, something went wrong I'm afraid.</p>;
    }

    // --------------------------------------------------
    // VIEW
    // --------------------------------------------------
    return (
        <section
            id="home"
            className="hero-section"
            aria-labelledby="hero-name"
        >
            <div className="hero">
                <div className="hero__purple" aria-hidden="true" />
                <div className="hero__yellow" aria-hidden="true" />

                <h1 id="hero-name" className="hero__name">
                    {hero.name}
                </h1>

                <div className="hero__jobTitle">
                    <h2>{hero.jobTitle}</h2>
                </div>

                <div
                    className="hero__circle"
                    role="img"
                    aria-label={hero.catchPhrase}
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
                                {hero.catchPhrase} &gt;&gt;&gt;&nbsp;
                            </textPath>
                        </text>
                    </svg>
                </div>

                <img
                    className="hero__image"
                    src={hero.mediaUrl}
                    alt={hero.catchPhrase}
                />

                <p className="hero__description">
                    {hero.description}
                </p>
            </div>
        </section>
    );
}