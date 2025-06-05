using CapaNegocio;
using Coworking2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coworking2.Paginas
{
    public partial class HacerReservacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                string Nombre = nombre.Value;
                DateTime fechaReserva = DateTime.Parse(Fecha.Value);
                
                BllReservas.InsertarReserva(null,null,1,fechaReserva,true);

                // Simulación de proceso (puedes conectarlo con la lógica de la base de datos)
                UtilControls.SweetBox("Reserva Confirmada!", $"Nombre: {nombre}\nFecha: {fechaReserva.ToString("yyyy-MM-dd")}\nPersonas: {personas}\nEdad: {edad}\nComentarios: {comentarios}", "success", this.Page, this.GetType());
            }
            catch (Exception ex)
            {
                UtilControls.SweetBox("Error!", ex.Message, "danger", this.Page, this.GetType());
            }
        }

    }
}