import "./navigation.css";

export default function Navigation() {
    return (
        <nav className="navigation" aria-label="Hoofdnavigatie">
            <a href="#home">Home</a>
            <a href="#portfolio">Portfolio</a>
            <a href="#about">Over mij</a>
            <a href="#contact">Contact</a>
        </nav>
    );
}