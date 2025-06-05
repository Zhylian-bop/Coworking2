<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Coworking2.Paginas.Registro" %>


<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registro</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="/Estilos/EstiloFormularios.css" />
</head>
<body class="d-flex justify-content-center align-items-center vh-100">
    <div class="container">
        <div class="card shadow-lg p-4 mx-auto" style="max-width: 800px;">
            <h2 class="text-center mb-4">Crear Cuenta</h2>
            <form id="formRegistro" runat="server">
                <div class="row">
                    <!-- Nombre -->
                    <div class="col-md-6 mb-3">
                        <label for="nombre" class="form-label">Nombre</label>
                        <input type="text" class="form-control" runat="server" id="nombre" placeholder="Ingresa tu nombre" required>
                    </div>

                    <!-- Apellido Paterno -->
                    <div class="col-md-6 mb-3">
                        <label for="apellidoPaterno" class="form-label">Apellido Paterno</label>
                        <input type="text" class="form-control" runat="server" id="apellidoPaterno" placeholder="Ingresa tu apellido paterno" required>
                    </div>

                    <!-- Apellido Materno -->
                    <div class="col-md-6 mb-3">
                        <label for="apellidoMaterno" class="form-label">Apellido Materno</label>
                        <input type="text" class="form-control" runat="server" id="apellidoMaterno" placeholder="Ingresa tu apellido materno" required>
                    </div>

                    <!-- Edad -->
                    <div class="col-md-6 mb-3">
                        <label for="edad" class="form-label">Edad</label>
                        <input type="number" class="form-control" runat="server" id="edad" placeholder="Ingresa tu edad" required>
                    </div>
                    <!-- Nombre de Usuario -->
                    <div class="col-md-6 mb-3">
                        <label for="nombre" class="form-label">Nombre de Usuario</label>
                        <input type="text" class="form-control" runat="server" id="nombreUsuario" placeholder="Ingresa Un Nombre de Usuario" required>
                    </div>

                    <!-- Correo Electrónico -->
                    <div class="col-md-6 mb-3">
                        <label for="email" class="form-label">Correo Electrónico</label>
                        <input type="email" class="form-control" runat="server" id="email" placeholder="Ejemplo@correo.com" required>
                    </div>

                    <!-- Teléfono -->
                    <div class="col-md-6 mb-3">
                        <label for="telefono" class="form-label">Teléfono</label>
                        <input type="tel" class="form-control" runat="server" id="telefono" placeholder="Ingresa tu número telefónico" required>
                    </div>

                    <!-- Contraseña -->
                    <div class="col-md-6 mb-3">
                        <label for="password" class="form-label">Contraseña</label>
                        <input type="password" class="form-control" runat="server" id="password" placeholder="Crea una contraseña segura" required>
                    </div>

                    <!-- Confirmar Contraseña -->
                    <div class="col-md-6 mb-3">
                        <label for="confirmPassword" class="form-label">Confirmar Contraseña</label>
                        <input type="password" class="form-control" runat="server" id="confirmPassword" placeholder="Repite tu contraseña" required>
                    </div>
                </div>
                <!-- Contenedor para la imagen de perfil -->
                <div class="text-center mb-3">
                    <label for="imagenPerfil" class="form-label">Selecciona una imagen de perfil</label>
                    <asp:FileUpload ID="imagenPerfilUpload" runat="server" CssClass="form-control" accept="image/*" />
                    <div class="mt-2">
                    <img id="previewImagen" src="/Multimedia/Imagenes/Default.jpg" alt="Vista previa de perfil" class="img-thumbnail" style="max-width: 150px;">
                    </div>
                </div>
                <!-- Botón de Registro -->
                <asp:Button ID="BtnRegistrar" runat="server" Text="Registrarse" OnClick="BtnRegistrar_Click" CssClass="btn btn-primary w-100 mt-3" />
            </form>
            
            <p class="text-center mt-3">
                ¿Ya tienes una cuenta? <a href="/Paginas/Login.aspx" class="text-primary">Inicia sesión aquí</a>
            </p>
        </div>
    </div>
    <script src="/Scripts/PerfilImagen.js"></script>
    <script src="/Scripts/Datos.js"></script>
</body>


</html>