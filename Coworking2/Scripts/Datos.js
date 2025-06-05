document.addEventListener("DOMContentLoaded", function () {
    // Función de validación para cualquier formulario
    function validarFormulario(form) {
        let inputs = form.querySelectorAll("input[required]");
        let valido = true;

        inputs.forEach(input => {
            if (!input.value.trim()) {
                valido = false;
                input.classList.add("is-invalid");
            } else {
                input.classList.remove("is-invalid");
            }
        });
        return valido;
    }
    // Validación en el formulario de registro
    let registroForm = document.querySelector("#registroForm");
    if (registroForm) {
        registroForm.addEventListener("submit", function (event) {
            if (!validarFormulario(registroForm)) {
                event.preventDefault();
            }
        });
    }
    // Validación en el formulario de inicio de sesión
    let loginForm = document.querySelector("#loginForm");
    if (loginForm) {
        loginForm.addEventListener("submit", function (event) {
            if (!validarFormulario(loginForm)) {
                event.preventDefault();
            }
        });
    }
});
