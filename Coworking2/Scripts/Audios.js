document.addEventListener("DOMContentLoaded", function () {
    const audios = [
        "/Multimedia/Audios/Beneath the Mask.mp3",
        "/Multimedia/Audios/Lo-Fi.mp3",
        "/Multimedia/Audios/Playground.mp3",
        "/Multimedia/Audios/Rain.mp3",
        "/Multimedia/Audios/Rock it for Me.mp3"
    ];

    const reproductorAudio = document.getElementById("reproductorAudio");
    const btnPlay = document.getElementById("btnPlay");
    const btnPause = document.getElementById("btnPause");
    const btnSiguiente = document.getElementById("btnSiguiente");
    const btnAnterior = document.getElementById("btnAnterior");
    const reproduciendoCancion = document.getElementById("reproduciendoCancion");

    let indiceActual = localStorage.getItem("audioTrack")
        ? audios.indexOf(localStorage.getItem("audioTrack"))
        : Math.floor(Math.random() * audios.length);

    if (indiceActual === -1) indiceActual = Math.floor(Math.random() * audios.length);

    function cargarCancion() {
        reproductorAudio.src = audios[indiceActual];
        reproductorAudio.load();

        if (reproduciendoCancion) {
            reproduciendoCancion.textContent = `Reproduciendo: ${audios[indiceActual].split("/").pop().replace(".mp3", "")}`;
        } else {
            console.error("Elemento #reproduciendoCancion no encontrado en el DOM.");
        }

        setTimeout(() => {
            reproductorAudio.play().catch(err => console.log("Reproducción bloqueada:", err));
        }, 500);
    }

    cargarCancion();

    window.addEventListener("beforeunload", function () {
        localStorage.setItem("audioTime", reproductorAudio.currentTime);
        localStorage.setItem("audioTrack", audios[indiceActual]);
    });

    btnPlay.addEventListener("click", () => reproductorAudio.play());
    btnPause.addEventListener("click", () => reproductorAudio.pause());

    btnSiguiente.addEventListener("click", function () {
        indiceActual = (indiceActual + 1) % audios.length;
        cargarCancion();
    });

    btnAnterior.addEventListener("click", function () {
        indiceActual = (indiceActual - 1 + audios.length) % audios.length;
        cargarCancion();
    });

    reproductorAudio.addEventListener("loadeddata", () => {
        reproductorAudio.play();
    });

    // Evento para reproducir automáticamente la siguiente canción cuando termine
    reproductorAudio.addEventListener("ended", function () {
        indiceActual = (indiceActual + 1) % audios.length;
        cargarCancion();
    });
});
