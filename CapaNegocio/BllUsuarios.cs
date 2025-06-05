using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaNegocio
{
    public class BllUsuarios
    {
        //listar
        public static List<Usuarios> ListaUsuarios(string usuario, string contraseña)
        {
            try
            {
                return DalUsuarios.GetUsuarios(usuario,contraseña);
            }
            catch (Exception ex) { throw; }

        }
        //insertar
        public static void InsertarUsuario(string usuario, string contraseña, string paramNombre, string paramApellidoPaterno, string paramApellidoMaterno, int paramEdad, string paramCorreoElerctronico, float paramTelefono,string paramNickName,string paramPaswword,string paramImagenPerfil)
        {
            try
            {
                DalUsuarios.InsertarUsuario(
                    usuario,
                    contraseña,
                    paramNombre,
                    paramApellidoPaterno,
                    paramApellidoMaterno,
                    paramEdad,
                    paramCorreoElerctronico,
                    paramTelefono,
                    paramNickName,
                    paramPaswword,
                    paramImagenPerfil);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //Actualizar
        public static void ActualizarUsuario(string usuario, string contraseña, int paramId, string paramNombre, string paramApellidoPaterno, string paramApellidoMaterno, int paramEdad, string paramCorreoElerctronico, float paramTelefono,string paramNickName, string paramPaswword, string paramImagenPerfil)
        {
            DalUsuarios.ActualizarUsuario(
                usuario,
                contraseña,
                paramId,
                paramNombre,
                paramApellidoPaterno,
                paramApellidoMaterno,
                paramEdad,
                paramCorreoElerctronico,
                paramTelefono,
                paramNickName,
                paramPaswword,
                paramImagenPerfil);


        }
        //Eliminar
        public static string EliminarUsuario(string usuario, string contraseña, int paramId)
        {
            DalUsuarios.EliminarUsuario(
                usuario,
                contraseña,
                paramId);
            return "1";
        }
        //jalar por id
        public static Usuarios ObtenerUsuarioPorId(string usuario, string contraseña, int paramId)
        {
            return DalUsuarios.ObtenerUsuarioPorId(usuario,contraseña,paramId);
        }
    }
}
