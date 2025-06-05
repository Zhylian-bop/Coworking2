using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaNegocio
{
    internal class BllEmpleados
    {
        //listar
        public static List<Empleados> ListaDeEmpleados(string usuario,string contraseña)
        {
            try
            {
                return DalEmpleados.ObtenerEmpleados(usuario,contraseña);
            }
            catch (Exception ex) { throw; }

        }
        //insertar
        public static void InsertarEmpleado(string usuario, string contraseña, string paramNombre, string paramApellidoPaterno, string paramApellidoMaterno, int paramEdad, string paramPuesto, float paramTelefono)
        {
            try
            {
                DalEmpleados.InsertarEmpleados(
                    usuario,
                    contraseña,
                    paramNombre,
                    paramApellidoPaterno,
                    paramApellidoMaterno,
                    paramEdad,
                    paramPuesto,
                    paramTelefono);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //Actualizar
        public static void ActChoferes(string usuario, string contraseña, int paramId, string paramNombre, string paramApellidoPaterno, string paramApellidoMaterno, int paramEdad, string paramPuesto, float paramTelefono)
        {
            DalEmpleados.ActualizarEmpleado(
                usuario,
                contraseña,
                paramId,
                paramNombre,
                paramApellidoPaterno,
                paramApellidoMaterno,
                paramEdad,
                paramPuesto,
                paramTelefono);
        }
        //Eliminar
        public static string EliminarEmpleado(string usuario, string contraseña, int paramId)
        {
            DalEmpleados.EliminarEmpleado(
                usuario,
                contraseña,
                paramId);
            return "1";
        }
        //jalar por id
        public static Empleados ObtenerEmpleadoPorId(string usuario, string contrañsea, int paramId)
        {
            return DalEmpleados.ObtenerEmpleadoPorId(
                usuario,
                contrañsea,
                paramId);
        }
    }
}
