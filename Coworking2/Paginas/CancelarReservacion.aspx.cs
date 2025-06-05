using Coworking2.Util;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace Coworking2.Paginas
{
    public partial class CancelarReservacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    refrescarGrid();
                }
                catch (Exception ex)
                {
                    UtilControls.SweetBox("Error!", ex.Message, "danger", this.Page, this.GetType());
                }
            }
        }

        public void refrescarGrid()
        {
            

            GVDetalles.DataSource = BllDetalles.ListaDetalles(null, null);
            GVDetalles.DataBind();
        }
        protected void GVDetalles_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GVDetalles.EditIndex = e.NewEditIndex;
            refrescarGrid(); // Recargar datos
        }

        protected void GVDetalles_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = GVDetalles.Rows[e.RowIndex];

                int idDetalles = int.Parse(GVDetalles.DataKeys[e.RowIndex].Value.ToString());
                int idReserva = int.Parse(((TextBox)row.FindControl("txtReserva")).Text);
                int idEspacio = int.Parse(((TextBox)row.FindControl("txtEspacio")).Text);
                int IdServicio = int.Parse(((TextBox)row.FindControl("txtServicio")).Text);
                decimal total = decimal.Parse(((TextBox)row.FindControl("txtTotal")).Text);
                DateTime fechaUso = DateTime.Parse(((TextBox)row.FindControl("txtFechaUso")).Text);
                DateTime horaEntrada = DateTime.Parse(((TextBox)row.FindControl("txtHoraEntrada")).Text);
                DateTime horaSalida = DateTime.Parse(((TextBox)row.FindControl("txtHoraSalida")).Text);

                BllDetalles.ActuallizarDetalles(null,null,idDetalles, idReserva, idEspacio,IdServicio, total, fechaUso, horaEntrada, horaSalida);

                GVDetalles.EditIndex = -1; // Salir del modo edición
                refrescarGrid();
            }
            catch (Exception ex)
            {
                UtilControls.SweetBox("Error!", ex.Message, "danger", this.Page, this.GetType());
            }
        }

        protected void GVDetalles_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GVDetalles.EditIndex = -1;
            refrescarGrid();
        }
        protected void GVDetalles_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                // Obtener ambos valores desde CommandArgument
                string[] valores = GVDetalles.Rows[e.RowIndex].Cells[0].Text.Split(',');
                int idDetalles = int.Parse(valores[0]);
                int idReserva = int.Parse(valores[1]);
                BllDetalles.EliminarDetalles(null, null, idDetalles);
                BllReservas.EliminarReserva(null, null, idReserva);
                UtilControls.SweetBox("Info", $"Reserva Eliminada", "info", this.Page, this.GetType());
            }
            catch (Exception ex)
            {
                UtilControls.SweetBox("Error!", ex.Message, "danger", this.Page, this.GetType());
            }
        }
    }
}
