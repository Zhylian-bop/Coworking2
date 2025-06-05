document.addEventListener("DOMContentLoaded", function () {
    const inputImagen = document.getElementById("imagenPerfil");
    const previewImagen = document.getElementById("previewImagen");

    inputImagen.addEventListener("change", function (event) {
        const archivo = event.target.files[0]; // Obtener el archivo seleccionado
        if (archivo) {
            const reader = new FileReader(); // Crear un lector de archivos
            reader.onload = function (e) {
                previewImagen.src = e.target.result; // Mostrar la imagen en el recuadro
            };
            reader.readAsDataURL(archivo); // Leer el archivo como DataURL
        }
    });
});
