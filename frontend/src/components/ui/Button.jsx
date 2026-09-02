import { Link } from "react-router-dom";
import "./button.css";

export default function Button({
                                   children,
                                   variant = "primary",
                                   className = "",
                                   to,
                                   ...props
                               }) {
    const classes = `button button--${variant} ${className}`;

    if (to) {
        return (
            <Link
                to={to}
                className={classes}
                {...props}
            >
                {children}
            </Link>
        );
    }

    return (
        <button
            className={classes}
            {...props}
        >
            {children}
        </button>
    );
}