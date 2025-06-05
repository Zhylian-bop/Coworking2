<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Servicios.aspx.cs" Inherits="Coworking2.Paginas.Servicios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <div class="container mt-4">
        <h2 class="text-center">Galería de Videos</h2>

        <div class="row">
            <!-- Videos locales -->
            <div class="col-md-6">
                <video controls class="w-100">
                    <source src="/Multimedia/Videos/coworking1.mp4" type="video/mp4">
                    Tu navegador no soporta el formato de video.
                </video>
            </div>
            <div class="col-md-6">
                <video controls class="w-100">
                    <source src="/Multimedia/Videos/coworking2.mp4" type="video/mp4">
                    Tu navegador no soporta el formato de video.
                </video>
            </div>
        </div>

        <div class="row mt-4">
            <!-- Videos por URL -->
            <div class="col-md-4">
                <iframe width="300" height="200" src="https://www.youtube.com/embed/IIrQzrX2bBQ" frameborder="0" allowfullscreen></iframe>
            </div>
            <div class="col-md-4">
                <iframe width="300" height="200" src="https://www.youtube.com/embed/jYpACsloIUk" frameborder="0" allowfullscreen></iframe>
            </div>
            <div class="col-md-4">
                <iframe width="300" height="200" src="https://www.youtube.com/embed/x54inur9e_c" frameborder="0" allowfullscreen></iframe>
            </div>
        </div>
    </div>
</asp:Content>
