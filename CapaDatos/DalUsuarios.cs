using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDatos
{
    public class DalUsuarios
    {
        // Método para obtener todos los usuarios
        public static List<Usuarios> GetUsuarios(string usuario, string contraseña)
        {
            try
            {
                DataSet dsUsuarios = MetodosConsultas.EjecutarDataSet("UsuarioListar",usuario,contraseña);

                List<Usuarios> ListaUsuarios = new List<Usuarios>();
                foreach (DataRow dr in dsUsuarios.Tables[0].Rows)
                {
                    ListaUsuarios.Add(new Usuarios(dr));
                }
                return ListaUsuarios;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener usuarios: " + ex.Message);
            }
        }

        // Método para insertar un usuario
        public static void InsertarUsuario(string usuario, string contraseña, string paramNombre, string paramApellidoPaterno, string paramApellidoMaterno, int paramEdad, string paramCorreoElerctronico, float paramTelefono,string paramNickname,string paramPassword, string paramImagenPerfil)
        {
            try
            {
                MetodosConsultas.EjecutarSinQuery("UsuarioInsertar",usuario,contraseña,
                    "@NombreUsuario", paramNombre,
                    "@ApellidoPaterno", paramApellidoPaterno,
                    "@ApellidoMaterno", paramApellidoMaterno,
                    "@Edad", paramEdad,
                    "@CorreoElectronico", paramCorreoElerctronico,
                    "@Telefono", paramTelefono,
                    "@NickName",paramNickname,
                    "@Password",paramPassword,
                    "@ImagenURL",paramImagenPerfil);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al insertar usuario: " + ex.Message);
            }
        }

        // Método para actualizar un usuario
        public static void ActualizarUsuario(string usuario, string contraseña, int paramId, string paramNombre, string paramApellidoPaterno, string paramApellidoMaterno, int paramEdad, string paramCorreoElerctronico, float paramTelefono,string paramNickname, string paramPassword,string paramImagenPerfil)
        {
            try
            {
                MetodosConsultas.EjecutarSinQuery("UsuarioActualizar", usuario,contraseña,
                    "@IdUsuario", paramId,
                    "@NombreUsuario", paramNombre,
                    "@ApellidoPaterno", paramApellidoPaterno,
                    "@ApellidoMaterno", paramApellidoMaterno,
                    "@Edad", paramEdad,
                    "@CorreoElectronico", paramCorreoElerctronico,
                    "@Telefono", paramTelefono,
                    "@NickName", paramNickname,
                    "@Password", paramPassword,
                    "@ImagenURL", paramImagenPerfil);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al actualizar usuario: " + ex.Message);
            }
        }

        // Método para eliminar un usuario
        public static void EliminarUsuario(string usuario, string contraseña, int paramId)
        {
            try
            {

                MetodosConsultas.EjecutarSinQuery("UsuarioEliminar", usuario,contraseña,
                    "@IdUsuario", paramId);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar usuario: " + ex.Message);
            }
        }

        // Método para obtener un usuario por su ID
        public static Usuarios ObtenerUsuarioPorId(string usuario, string contraseña, int paramId)
        {
            try
            {
                DataSet dsUsuarios = MetodosConsultas.EjecutarDataSet("UsuarioBuscarPorId", usuario,contraseña, "@IdUsuario", paramId);

                if (dsUsuarios.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsUsuarios.Tables[0].Rows[0];
                    return new Usuarios(dr);
                }
                else
                {
                    return new Usuarios();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener usuario por ID: " + ex.Message);
            }
        }
    }

}
