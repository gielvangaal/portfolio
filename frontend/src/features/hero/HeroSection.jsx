import "./hero.css";

export default function HeroSection() {
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
                    Giel van Gaal
                </h1>

                <div className="hero__role">
                    <h2>Linux Engineer &amp; Software Developer</h2>
                </div>

                <div
                    className="hero__circle"
                    role="img"
                    aria-label="De wereld vooruit helpen"
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
                                de wereld vooruit helpen &gt;&gt;&gt;&nbsp;
                            </textPath>
                        </text>
                    </svg>
                </div>

                <img
                    className="hero__image"
                    src="/giel.webp"
                    alt="Giel van Gaal"
                />

                <p className="hero__tagline">
                    Backend &amp; DevOps · Software Engineering · Getting things done
                </p>
            </div>
        </section>
    );
}