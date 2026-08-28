import { useState } from "react";

import "./accordion.css";

export default function Accordion({
                                      items,
                                      defaultOpenId = null,
                                      renderContent,
                                  }) {
    const [openId, setOpenId] = useState(defaultOpenId);

    function handleToggle(id) {
        setOpenId((currentId) =>
            currentId === id ? null : id
        );
    }

    return (
        <div className="accordion">
            {items.map((item) => {
                const isOpen = openId === item.id;

                return (
                    <article
                        key={item.id}
                        className={`accordion-item ${
                            isOpen ? "accordion-item--open" : ""
                        }`}
                    >
                        <button
                            type="button"
                            className="accordion-header"
                            onClick={() => handleToggle(item.id)}
                            aria-expanded={isOpen}
                        >
                            <span className="accordion-title">
                                {item.title}
                            </span>

                            <span
                                className="accordion-toggle"
                                aria-hidden="true"
                            >
                                {isOpen ? "−" : "+"}
                            </span>
                        </button>

                        {isOpen && (
                            <div className="accordion-body">
                                {renderContent(item)}
                            </div>
                        )}
                    </article>
                );
            })}
        </div>
    );
}