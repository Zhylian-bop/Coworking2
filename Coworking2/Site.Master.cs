using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coworking2
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsuarioLogueado"] != null && (bool)Session["UsuarioLogueado"] == true)
            {
                perfilMenu.Style["display"] = "block"; // Mostrar el menú de perfil
                perfilDropdown.Disabled = false; // Activar el botón de perfil

                btnSesion.Style["display"] = "none"; // Ocultar los botones de inicio de sesión
            }
            else
            {
                perfilMenu.Style["display"] = "none"; // Ocultar el menú de perfil
                perfilDropdown.Disabled = true; // Desactivar el botón de perfil

                btnSesion.Style["display"] = "flex"; // Mostrar los botones de inicio de sesión
            }
        }

    }
}