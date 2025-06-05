using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coworking2.Paginas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string Nusuario = Usuario.Value;
            string contraseña = password.Value;
            string cadena = ConfiguracionConexion.ObtenerCadenaConexion(null, null);

            if (ValidarLogin(Nusuario, contraseña, cadena))
            {
                // Guarda el estado de sesión
                Session["UsuarioLogueado"] = true;


                // Redirige a la página de inicio
                Response.Redirect("Inicio.aspx");
            }
        }

      
        public static bool ValidarLogin(string nombreUsuario, string contraseña,string connectionString)
        {
        
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Contraseña FROM Usuarios WHERE NickName = @Usuario or CorreoElectronico = @Usuario";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", nombreUsuario);

                    conn.Open();
                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null)
                    {
                        return resultado.ToString() == Registro.encriptar(contraseña);
                    }
                    return false;
                }
            }
        }

    }
}