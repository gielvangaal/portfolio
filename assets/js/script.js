//   cards video on hover
document.querySelectorAll(".card-container").forEach(card => {
    const container = card.querySelector(".media-card-container");
    const video = card.querySelector(".card-video");
    const img = card.querySelector(".card-img");

    container.addEventListener("mouseenter", () => {
        video.style.display = "block"; // Video tonen
        video.play();
        img.style.opacity = "0"; // Afbeelding verbergen (fade-out effect)
        // video.style.transition = "opacity 3s ease";
    });

    container.addEventListener("mouseleave", () => {
        video.pause();
        video.style.display = "none"; // Video verbergen
        img.style.opacity = "1"; // Afbeelding tonen (fade-in effect)
    });
});

// wordcloud
const svg = d3.select("#wordcloud");
const groot = ["Organiseren", "Uitdagen", "Leergierig", "Humor"];
const middel = ["Relaxt", "Komt goed", "Etc.", "Node.js", "Flask", "Express", "TypeScript", "Svelte"];
const klein = ["AI", "NLP", "Data", "API", "GraphQL", "Docker", "Linux", "GIT", "Redux", "MongoDB", "SQL", "NoSQL"];

const width = 800, height = 400;

function generateWordCloud() {
    const words = [];

    // Voeg woorden toe met verschillende groottes
    groot.forEach(word => words.push({ text: word, size: 60 }));
    middel.forEach(word => words.push({ text: word, size: 40 }));
    klein.forEach(word => words.push({ text: word, size: 20 }));

    d3.select("svg").selectAll("*").remove(); // Verwijder oude woorden
    d3.select("svg").style("background-color", "#FAFAFA"); // Achtergrondkleur

    const layout = d3.layout.cloud()
        .size([width, height])
        .words(words)
        .padding(10)
        .rotate(() => (Math.random() > 0.5 ? 0 : 90))
        .fontSize(d => d.size)
        .on("end", draw);

    layout.start();

    function draw(words) {
        d3.select("svg")
            .append("g")
            .attr("transform", `translate(${width / 2},${height / 2})`)
            .selectAll("text")
            .data(words)
            .enter().append("text")
            .style("font-size", d => `${d.size}px`)
            .style("fill", "black")
            .style("font-family", "'Be Vietnam Pro', sans-serif") // Nieuw lettertype
            .attr("text-anchor", "middle")
            .attr("transform", d => `translate(${d.x},${d.y}) rotate(${d.rotate})`)
            .text(d => d.text);
    }
}

// init
generateWordCloud();