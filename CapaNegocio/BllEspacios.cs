using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaNegocio
{
    public class BllEspacios
    {
        //listar
        public static List<Espacios> ListaDeEspacios(string usuario, string contraseña)
        {
            try
            {
                return DalEspacios.ObtenerEspacios(usuario,contraseña);
            }
            catch (Exception ex) { throw; }

        }
        //insertar
        public static void InsertarEspacio(string usuario, string contraseña, string paramNombreEspacio, string paramUbicacion, int paramCapacidad, decimal paramPrecio, int paramEncargadoId)
        {
            try
            {
                DalEspacios.InsertarEspacios(
                    usuario,
                    contraseña,
                    paramNombreEspacio,
                    paramUbicacion,
                    paramCapacidad,
                    paramPrecio,
                    paramEncargadoId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //Actualizar
        public static void ActualizarEspacio(string usuario, string contraseña, int paramId, string paramNombreEspacio, string paramUbicacion, int paramCapacidad, decimal paramPrecio, int paramEncargadoId)
        {
            DalEspacios.ActualizarEspacio(
                usuario,
                contraseña,
                paramId,
                paramNombreEspacio,
                paramUbicacion,
                paramCapacidad,
                paramPrecio,
                paramEncargadoId);
        }
        //Eliminar
        public static string EliminarEspacio(string usuario, string contraseña, int paramId)
        {
            try
            {
                DalEspacios.EliminarEspacio(
                    usuario,
                    contraseña,
                    paramId
                    );
                return "1";
            }
            catch (System.Exception ex) { throw; }
        }
        //jalar por id
        public static Espacios ObtenerEspacioPorId(string usuario, string contraseña, int paramId)
        {
            return DalEspacios.ObtenerEspacioPorId(usuario,contraseña,paramId);
        }
    }
}
