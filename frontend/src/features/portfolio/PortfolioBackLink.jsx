import { Link } from "react-router-dom";

import "./portfolioButton.css";
import "./portfolioBackLink.css";

export default function PortfolioBackLink() {
    return (
        <Link
            className="portfolio-button portfolio-back-link"
            to="/#portfolio"
        >
            Terug
        </Link>
    );
}
