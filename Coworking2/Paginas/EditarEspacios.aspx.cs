using CapaDatos;
using Coworking2.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace Coworking2.Paginas
{
    public partial class EditarEspacios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    refrescarGridEspacios();
                }
                catch (Exception ex)
                {
                    UtilControls.SweetBox("Error!", ex.Message, "danger", this.Page, this.GetType());
                }
            }
        }

        public void refrescarGridEspacios()
        {
            GVEspacios.DataSource = BllEspacios.ListaDeEspacios(null, null);
            GVEspacios.DataBind();
        }
        protected void GVEspacios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GVEspacios.EditIndex = e.NewEditIndex;
            refrescarGridEspacios(); // Volver a cargar datos
        }

        protected void GVEspacios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = GVEspacios.Rows[e.RowIndex];

                int idEspacio = int.Parse(GVEspacios.DataKeys[e.RowIndex].Value.ToString());
                int idEncargado = int.Parse(((TextBox)row.FindControl("txtEncargado")).Text);
                string nombreEspacio = ((TextBox)row.FindControl("txtNombre")).Text;
                string direccion = ((TextBox)row.FindControl("txtDireccion")).Text;
                int capacidad = int.Parse(((TextBox)row.FindControl("txtCapacidad")).Text);
                decimal costo = decimal.Parse(((TextBox)row.FindControl("txtCosto")).Text);

                BllEspacios.ActualizarEspacio(null,null,idEspacio, nombreEspacio, direccion, capacidad, costo, idEncargado);

                GVEspacios.EditIndex = -1; // Salir del modo edición
                refrescarGridEspacios();
            }
            catch (Exception ex)
            {
                UtilControls.SweetBox("Error!", ex.Message, "danger", this.Page, this.GetType());
            }
        }

        protected void GVEspacios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GVEspacios.EditIndex = -1;
            refrescarGridEspacios();
        }

        protected void GVEspacios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int idEspacio = int.Parse(GVEspacios.DataKeys[e.RowIndex].Value.ToString());
                BllEspacios.EliminarEspacio(null, null, idEspacio);
                UtilControls.SweetBox("Info", $"Espacio eliminado", "info", this.Page, this.GetType());
            }
            catch (Exception ex)
            {
                UtilControls.SweetBox("Error!", ex.Message, "danger", this.Page, this.GetType());
            }
        }



    }
}