import { Link } from "react-router-dom";

import "./portfolioButton.css";
import "./portfolioBackLink.css";
import Button from "../../components/ui/Button.jsx";

export default function PortfolioBackLink() {
    return (
        <Button variant="primary"
            className="portfolio-button portfolio-back-link"
            to="/#portfolio"
        >
            Terug
        </Button>
    );
}
