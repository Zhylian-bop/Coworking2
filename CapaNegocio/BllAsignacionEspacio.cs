using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaNegocio
{
    internal class BllAsignacionEspacio
    {
        //listar
        public static List<AsignacionEspacios> ListaDeAsignaciones(string usuario, string contraseña)
        {
            try
            {
                return DalAsignacionEspacio.ObtenerAsignaciones(
                    usuario,
                    contraseña);
            }
            catch (Exception ex) { throw; }

        }
        //insertar
        public static void InsertarAsignacion(string usuario, string contraseña, int paramIdEspacio, int paramIdEmpleado)
        {
            try
            {
                DalAsignacionEspacio.InsertarAsignacion(
                    usuario,
                    contraseña,
                    paramIdEspacio,
                    paramIdEmpleado);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //Actualizar
        public static void ActualizarAsignaciones(string usuario, string contraseña, int paramIdAsignacion, int paramIdEspacio, int paramIdEmpleado)
        {
            DalAsignacionEspacio.ActualizarAsignacion(
                usuario,
                contraseña,
                paramIdAsignacion,
                paramIdEspacio,
                paramIdEmpleado);


        }
        //Eliminar
        public static string EliminarAsignacion(string usuario, string contraseña, int paramId)
        {
            DalAsignacionEspacio.EliminarAsignacion(
                usuario,
                contraseña,
                paramId);
            return "1";
        }
        //jalar por id
        public static AsignacionEspacios ObtenerEspacioPorId(string usuario, string contraseña, int paramId)
        {
            return DalAsignacionEspacio.ObtenerasignacionPorId(
                    usuario,
                    contraseña,
                    paramId);
        }
    }
}
