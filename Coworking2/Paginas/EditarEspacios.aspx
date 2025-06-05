<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarEspacios.aspx.cs" Inherits="Coworking2.Paginas.EditarEspacios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <form id="form1" runat="server">
    <div class="container mt-4">
        <h2 class="text-center mb-4">Lista de Espacios</h2>
        <div class="table-responsive">
            <asp:GridView ID="GVEspacios" runat="server" AutoGenerateColumns="False"
    CssClass="table table-grid" OnRowEditing="GVEspacios_RowEditing"
    OnRowUpdating="GVEspacios_RowUpdating" OnRowCancelingEdit="GVEspacios_RowCancelingEdit"
    OnRowDeleting="GVEspacios_RowDeleting">
    <Columns>
        <asp:BoundField DataField="IdEspacio" HeaderText="ID Espacio" ReadOnly="True" />
        <asp:TemplateField HeaderText="Encargado">
            <ItemTemplate>
                <asp:Label ID="lblEncargado" runat="server" Text='<%# Eval("IdEncargado") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtEncargado" runat="server" Text='<%# Bind("IdEncargado") %>' CssClass="form-control" />
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Nombre Espacio">
            <ItemTemplate>
                <asp:Label ID="lblNombre" runat="server" Text='<%# Eval("NombreEspacio") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtNombre" runat="server" Text='<%# Bind("NombreEspacio") %>' CssClass="form-control" />
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Dirección">
            <ItemTemplate>
                <asp:Label ID="lblDireccion" runat="server" Text='<%# Eval("Direccion") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtDireccion" runat="server" Text='<%# Bind("Direccion") %>' CssClass="form-control" />
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Capacidad">
            <ItemTemplate>
                <asp:Label ID="lblCapacidad" runat="server" Text='<%# Eval("Capacidad") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtCapacidad" runat="server" Text='<%# Bind("Capacidad") %>' CssClass="form-control" />
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Costo">
            <ItemTemplate>
                <asp:Label ID="lblCosto" runat="server" Text='<%# Eval("CostoEspacio", "{0:C}") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtCosto" runat="server" Text='<%# Bind("CostoEspacio") %>' CssClass="form-control" />
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" ButtonType="Button" EditText="Editar" UpdateText="Guardar" CancelText="Cancelar" />
        <asp:TemplateField HeaderText="Eliminar">
            <ItemTemplate>
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger btn-sm" CommandName="Delete" CommandArgument='<%# Eval("IdEspacio") %>' />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>

        </div>
    </div>
</form>

</asp:Content>
