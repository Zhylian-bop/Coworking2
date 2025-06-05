<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CancelarReservacion.aspx.cs" Inherits="Coworking2.Paginas.CancelarReservacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
        <form id="form1" runat="server">
    <div class="container mt-4">
        <h2 class="text-center mb-4">Detalles de Reservas</h2>
        <div class="table-responsive">
            <asp:GridView ID="GVDetalles" runat="server" AutoGenerateColumns="False"
    CssClass="table table-grid" OnRowEditing="GVDetalles_RowEditing"
    OnRowUpdating="GVDetalles_RowUpdating" OnRowCancelingEdit="GVDetalles_RowCancelingEdit"
    OnRowDeleting="GVDetalles_RowDeleting" DataKeyNames="IdDetalles">
    <Columns>
        <asp:BoundField DataField="IdDetalles" HeaderText="ID Detalles" ReadOnly="True" />
        <asp:TemplateField HeaderText="ID Reserva">
            <ItemTemplate>
                <asp:Label ID="lblReserva" runat="server" Text='<%# Eval("IdReserva") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtReserva" runat="server" Text='<%# Bind("IdReserva") %>' CssClass="form-control" />
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ID Espacio">
            <ItemTemplate>
                <asp:Label ID="lblEspacio" runat="server" Text='<%# Eval("IdEspacio") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtEspacio" runat="server" Text='<%# Bind("IdEspacio") %>' CssClass="form-control" />
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Total">
            <ItemTemplate>
                <asp:Label ID="lblTotal" runat="server" Text='<%# Eval("Total", "{0:C}") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtTotal" runat="server" Text='<%# Bind("Total") %>' CssClass="form-control" />
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Fecha Uso">
            <ItemTemplate>
                <asp:Label ID="lblFechaUso" runat="server" Text='<%# Eval("FechaUso", "{0:yyyy-MM-dd}") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtFechaUso" runat="server" Text='<%# Bind("FechaUso") %>' CssClass="form-control" />
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Hora Entrada">
            <ItemTemplate>
                <asp:Label ID="lblHoraEntrada" runat="server" Text='<%# Eval("HoraEntrada", "{0:HH:mm}") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtHoraEntrada" runat="server" Text='<%# Bind("HoraEntrada") %>' CssClass="form-control" />
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Hora Salida">
            <ItemTemplate>
                <asp:Label ID="lblHoraSalida" runat="server" Text='<%# Eval("HoraSalida", "{0:HH:mm}") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtHoraSalida" runat="server" Text='<%# Bind("HoraSalida") %>' CssClass="form-control" />
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" ButtonType="Button" EditText="Editar" UpdateText="Guardar" CancelText="Cancelar" />
        <asp:TemplateField HeaderText="Eliminar">
            <ItemTemplate>
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger btn-sm" CommandName="Delete" CommandArgument='<%# Eval("IdDetalles") %>' />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>

        </div>
    </div>
</form>
</asp:Content>
