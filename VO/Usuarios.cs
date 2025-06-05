using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Usuarios
    {
       
        //Propiedades
        public int Id { get; set;}
        public string NombreUsuario { get; set;}
        public string ApellidoPaternoUsuario { get; set;}
        public string ApellidoMaternoUsuario { get; set; }
        public int Edad { get; set;}
        public string CorreoElectronicoUsuario { get; set;}
        public float TelefonoUsuario { get; set;}
        public string NickName {  get; set;}
        public string password {  get; set;}
        public string ImagenPerfil {  get; set;}

        //Que hara si recibe valores
        public Usuarios(DataRow Dr) {
            Id = int.Parse(Dr["Id"].ToString());
            NombreUsuario = Dr["NombreUsuario"].ToString();
            ApellidoPaternoUsuario = Dr["ApellidoPaternoUsuario"].ToString();
            ApellidoMaternoUsuario = Dr["ApellidoMaternoUsuario"].ToString();
            Edad = int.Parse(Dr["Edad"].ToString());
            CorreoElectronicoUsuario = Dr["CorreoElectronicoUsuario"].ToString();
            TelefonoUsuario = float.Parse(Dr["Telefono"].ToString());
            NickName = Dr["NickName"].ToString();
            password = Dr["Password"].ToString();
            ImagenPerfil = Dr["ImagenPerfil"].ToString();
        }
        public Usuarios() {
            Id = 0;
            NombreUsuario = string.Empty;
            ApellidoPaternoUsuario=string.Empty;
            ApellidoMaternoUsuario = string.Empty;
            Edad = 0;
            CorreoElectronicoUsuario=string.Empty;
            TelefonoUsuario = 0;
            NickName=string.Empty;
            password = string.Empty;
            ImagenPerfil = string.Empty;
        }

    }
}
