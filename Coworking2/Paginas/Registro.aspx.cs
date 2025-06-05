using CapaDatos;
using CapaNegocio;
using Coworking2.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VO;


namespace Coworking2.Paginas
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static string encriptar(string contraseña) {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contraseña));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes) builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
       
        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = nombreUsuario.Value;
            string contrasena1 = password.Value;
            string contrasena2 = confirmPassword.Value;

            if (contrasena1 == contrasena2)
            {
                string nombreUsuario = nombre.Value;
                string ApellidoPaternoUsuario = apellidoPaterno.Value;
                string ApellidoMaternoUsuario = apellidoMaterno.Value;
                int Edad = int.Parse(edad.Value);
                string CorreoElectronico = email.Value;
                float telefonoUsuario = float.Parse(telefono.Value);
                // Ruta donde se guardarán las imágenes de perfil
                string rutaDirectorio = Server.MapPath("~/Multimedia/ImagenesUsuarios/");

                // Validar si el usuario subió una imagen
                if (imagenPerfilUpload.HasFile)
                {
                    string extension = Path.GetExtension(imagenPerfilUpload.FileName); // Obtener extensión
                    string nombreArchivo = nombreUsuario + extension; // Renombrar con el nombre de usuario
                    string rutaCompleta = Path.Combine(rutaDirectorio, nombreArchivo); // Generar ruta completa

                    // Guardar la imagen en la carpeta del servidor
                    imagenPerfilUpload.SaveAs(rutaCompleta);

                    // URL accesible desde el sitio web
                    string urlImagenPerfil = "/Multimedia/ImagenesUsuarios/" + nombreArchivo;
                }
                    try
                {
                    
                    BllUsuarios.InsertarUsuario(null, null, nombreUsuario, ApellidoPaternoUsuario, ApellidoMaternoUsuario, Edad, CorreoElectronico, telefonoUsuario, usuario, encriptar(contrasena1),rutaDirectorio);
                   
                    UtilControls.SweetBoxConfirm("Exito!", "Usuario creado con extio", "success", "Login.aspx", this.Page, this.GetType());
                }
                catch (Exception ex)
                {
                }
            }
            else { 
                UtilControls.SweetBoxConfirm("Error!","Las contraseñas no coinciden, favor de verificar","Error","Registro.aspx",this.Page, this.GetType());
            }
        }
    }
}