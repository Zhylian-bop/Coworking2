using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaNegocio
{
    public class BllReservas
    {
        //listar
        public static List<Reservas> ListaDeReservas(string usuario, string contraseña)
        {
            try
            {
                return DalReservas.ObtenerReservas(usuario, contraseña);
            }
            catch (Exception ex) { throw; }

        }
        //insertar
        public static void InsertarReserva(string usuario, string contraseña, int paramIdUsuario, DateTime paramFechaReserva, bool paramEstado)
        {
            try
            {
                DalReservas.InsertarReservas(
                    usuario,
                    contraseña,
                    paramIdUsuario,
                    paramFechaReserva,
                    paramEstado);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //Actualizar
        public static void ActualizarReserva(string usuario, string contraseña, int paramIdReserva, int paramIdUsuario, DateTime paramFechaReserva, bool paramEstado)
        {
            DalReservas.ActualizarReserva(
                usuario,
                contraseña,
                paramIdReserva,
                paramIdUsuario,
                paramFechaReserva,
                paramEstado);
        }
        //Eliminar
        public static string EliminarReserva(string usuario, string contraseña, int paramId)
        {
            try
            {
                DalReservas.EliminarReserva(
                    usuario,
                    contraseña,
                    paramId);
                return "1";
            }
            catch (System.Exception ex) { throw; }
        }
        //jalar por id
        public static Reservas ObtenerReservaPorId(string usuario, string contraseña, int paramId)
        {
            return DalReservas.ObtenerReservaPorId(
                usuario,
                contraseña,
                paramId);
        }
    }
}
