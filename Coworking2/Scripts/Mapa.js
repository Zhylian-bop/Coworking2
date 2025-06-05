// Inicializar el mapa centrado en Buenavista, Ciudad de México
var map = L.map('map').setView([19.4433, -99.1523], 12);

// Agregar capa de mapas base
L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '&copy; OpenStreetMap contributors'
}).addTo(map);
// Lista de ubicaciones con imágenes
var locations = [
    { lat: 19.4433, lng: -99.1523, name: "Buenavista, CDMX", img: "/Multimedia/Imagenes/Lugares/coworking1.png" },
    { lat: 19.4326, lng: -99.1332, name: "Centro Histórico, CDMX", img: "/Multimedia/Imagenes/Lugares/coworking2.png" },
    { lat: 19.4260, lng: -99.1677, name: "Paseo de la Reforma, CDMX", img: "/Multimedia/Imagenes/Lugares/coworking3.png" },
    { lat: 19.4877, lng: -99.1266, name: "Polanco, CDMX", img: "/Multimedia/Imagenes/Lugares/coworking4.png" },
    { lat: 19.3689, lng: -99.1821, name: "Universidad Nacional, CDMX", img: "/Multimedia/Imagenes/Lugares/coworking5.png" },
    { lat: 19.4561, lng: -99.1606, name: "Monumento a la Revolución, CDMX", img: "/Multimedia/Imagenes/Lugares/coworking6.png" },
    { lat: 19.5711, lng: -99.0034, name: "Teotihuacán, Edo. de México", img: "/Multimedia/Imagenes/Lugares/coworking7.png" },
    { lat: 19.2813, lng: -99.6489, name: "Toluca, Edo. de México", img: "/Multimedia/Imagenes/Lugares/coworking8.png" },
    { lat: 19.6585, lng: -99.2061, name: "Valle de Bravo, Edo. de México", img: "/Multimedia/Imagenes/Lugares/coworking9.png" },
    { lat: 19.3500, lng: -99.1500, name: "Naucalpan, Edo. de México", img: "/Multimedia/Imagenes/Lugares/coworking10.png" }
];

// Crear marcadores con popups que incluyen imágenes
locations.forEach(function (location) {
    var popupContent = `
        <b>${location.name}</b><br>
        <img src="${location.img}" width="200" style="border-radius:5px;" alt="Imagen de ${location.name}"><br>
        <small>Ubicación estratégica en el mapa</small>
    `;

    L.marker([location.lat, location.lng]).addTo(map)
        .bindPopup(popupContent);
});

