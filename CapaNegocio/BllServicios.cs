using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;
using CapaDatos;

namespace CapaNegocio
{
    internal class BllServicios
    {
        //listar
        public static List<Servicios> ListaServicios(string usuario,string contraseña)
        {
            try
            {
                return DalServicios.ObtenerServicios(usuario,contraseña);
            }
            catch (Exception ex) { throw; }

        }
        //insertar
        public static void InsertarServicio(string usuario, string contraseña,string paramServicio, string paramDescripcion, decimal paramCosto)
        {
            try
            {
                DalServicios.InsertarServicio(
                    usuario,
                    contraseña,
                    paramServicio,
                    paramDescripcion,
                    paramCosto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //Actualizar
        public static void ActualizarServicios(string usuario, string contraseña,int paramId, string paramServicio, string paramDescripcion, decimal paramCosto)
        {
            DalServicios.ActualizarServicio(
                usuario,
                contraseña,
                paramId,
                paramServicio,
                paramDescripcion,
                paramCosto);


        }
        //Eliminar
        public static string EliminarServicio(string usuario, string contraseña,int paramId)
        {
            try
            {
                DalServicios.EliminarServicio(
                    usuario,
                    contraseña,
                    paramId);
                return "1";
            }
            catch (System.Exception ex) { throw; }
        }
        //jalar por id
        public static Servicios ServiciosBuscarPorId(string usuario, string contraseña,int paramId)
        {
            return DalServicios.ObtenerServicioPorId(usuario,contraseña,paramId);
        }
    }
}
