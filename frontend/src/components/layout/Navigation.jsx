import { Link } from "react-router-dom";

import "./navigation.css";

export default function Navigation() {
    return (
        <nav className="navigation" aria-label="Hoofdnavigatie">
            <Link to="/#home">Home</Link>
            <Link to="/#portfolio">Portfolio</Link>
            <Link to="/#about">Over mij</Link>
            <Link to="/#contact">Contact</Link>
        </nav>
    );
}
