import "./sectionHeading.css";

export default function SectionHeading({ children, as = "h2" }) {
    const Heading = as;

    return (
        <div className="section-heading">
            <Heading>{children}</Heading>
            <div className="section-heading__highlight" aria-hidden="true" />
        </div>
    );
}