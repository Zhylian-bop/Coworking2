<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Coworking2.Paginas.Login" %>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Iniciar Sesión</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="/Estilos/EstiloFormularios.css" />
</head>
<body class="d-flex justify-content-center align-items-center vh-100">
    <div class="container">
        <div class="card shadow-lg p-4 mx-auto" style="max-width: 400px;">
            <h2 class="text-center mb-4">Iniciar Sesión</h2>
            <form runat="server">
                <div class="mb-3">
                    <label for="usuario" class="form-label">Usuario o Correo Electronico</label>
                    <input type="Text" class="form-control" runat="server" id="Usuario" placeholder="Ejemplo@correo.com" required>
                </div>
                <div class="mb-3">
                    <label for="password" class="form-label">Contraseña</label>
                    <input type="password" class="form-control" runat="server" id="password" placeholder="Ingresa tu contraseña" required>
                </div>
                <asp:Button ID="BtnRegistrar" runat="server" Text="Iniciar Sesion" OnClick="BtnRegistrar_Click" CssClass="btn btn-primary w-100 mt-3" />
            </form>
            <p class="text-center mt-3">
                ¿No tienes una cuenta? <a href="/Paginas/Registro.aspx" class="text-primary">Regístrate aquí</a>
            </p>
        </div>
    </div>
        <script src="/Scripts/Datos.js"></script>
</body>
</html>