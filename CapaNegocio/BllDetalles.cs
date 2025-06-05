using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaNegocio
{
    public class BllDetalles
    {
        //listar
        public static List<Detalles> ListaDetalles(string usuario, string contraseña)
        {
            try
            {
                return DalDetalles.ObtenerDetalles(usuario,contraseña);
            }
            catch (Exception ex) { throw; }

        }
        //insertar
        public static void InsertarDetalles(string usuario, string contraseña,int paramIdReserva, int paramIdEspacio, int paramIdServicio, decimal paramTotal, DateTime paramFechaUso, DateTime paramHoraEntrada, DateTime paramHoraSalida)
        {
            try
            {
                DalDetalles.InsertarDetalles(
                    usuario,
                    contraseña,
                    paramIdReserva,
                    paramIdEspacio,
                    paramIdServicio,
                    paramTotal,
                    paramFechaUso,
                    paramHoraEntrada,
                    paramHoraSalida);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //Actualizar
        public static void ActuallizarDetalles(string usuario, string contraseña, int paramIdDetalles, int paramIdReserva, int paramIdEspacio, int paramIdServicio, decimal paramTotal, DateTime paramFechaUso, DateTime paramHoraEntrada, DateTime paramHoraSalida)
        {
            DalDetalles.ActualizarDetalles(
                usuario,
                contraseña,
                paramIdDetalles,
                paramIdReserva,
                paramIdEspacio,
                paramIdServicio,
                paramTotal,
                paramFechaUso,
                paramHoraEntrada,
                paramHoraSalida);


        }
        //Eliminar
        public static string EliminarDetalles(string usuario, string contraseña,int paramIdDetalle)
        {
            try
            {
                DalDetalles.EliminarDetalles(usuario, contraseña, paramIdDetalle);
                return "1";
            }
            catch (System.Exception ex) { throw; }
        }
        //jalar por id
        public static Detalles DetallesBuscarPorId(string usuario, string contraseña,int paramId)
        {
            return DalDetalles.ObtenerDetallesPorId(usuario,contraseña,paramId);
        }
    }
}
