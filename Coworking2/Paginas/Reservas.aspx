<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reservas.aspx.cs" Inherits="Coworking2.Paginas.Reservas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <div class="container mt-4">
    <div class="form-container">
        <h2 class="text-center">Formulario de Reserva</h2>
        <form id="reservaForm">
            <div class="row">
                <div class="col-md-6 mb-3">
                    <label for="nombre" class="form-label">Nombre Completo</label>
                    <input type="text" class="form-control" id="nombre" placeholder="Ingresa tu nombre" required pattern="[A-Za-zÁÉÍÓÚáéíóúÑñ\s]+" title="Solo letras y espacios">
                </div>
                <div class="col-md-6 mb-3">
                    <label for="email" class="form-label">Correo Electrónico</label>
                    <input type="email" class="form-control" id="email" placeholder="Ejemplo@correo.com" required>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6 mb-3">
                    <label for="fecha" class="form-label">Fecha de Reserva</label>
                    <input type="date" class="form-control" id="fecha" required>
                </div>
                <div class="col-md-6 mb-3">
                    <label for="personas" class="form-label">Número de Personas</label>
                    <input type="number" class="form-control" id="personas" min="1" required>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6 mb-3">
                    <label for="edad" class="form-label">Edad</label>
                    <input type="number" class="form-control" id="edad" min="1" max="120" required>
                </div>
                <div class="col-md-6 mb-3">
                    <label for="comentarios" class="form-label">Comentarios</label>
                    <textarea class="form-control" id="comentarios" rows="3" placeholder="Añade detalles adicionales"></textarea>
                </div>
            </div>
            <div class="text-center">
                <button type="submit" class="btn btn-primary">Reservar Ahora</button>
            </div>
        </form>
    </div>
</div>

</asp:Content>
