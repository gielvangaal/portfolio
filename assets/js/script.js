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

document.querySelector("#btn-terug").addEventListener("click", function() {
    window.history.back();
});