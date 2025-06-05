using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDatos
{
    public class DalReservas
    {
        public static List<Reservas> ObtenerReservas(string usuario,string contraseña)
        {
            try
            {
                DataSet Dsreservas;
                Dsreservas = MetodosConsultas.EjecutarDataSet("ReservasListar",usuario,contraseña);
                List<Reservas> ListaReservas = new List<Reservas>();
                foreach (DataRow Dr in Dsreservas.Tables[0].Rows)
                {
                    ListaReservas.Add(new Reservas(Dr));
                }
                return ListaReservas;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void InsertarReservas(string usuario,string contraseña,int paramIdUsuario, DateTime paramFechaReserva, bool paramEstado)
        {
            try
            {
                MetodosConsultas.EjecutarSinQuery("EmpleadosInsertar",usuario,contraseña,
                    "@IdUsuario",paramIdUsuario,
                    "@FechaReserva",paramFechaReserva,
                    "@Estado",paramEstado);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void ActualizarReserva(string usuario, string contraseña,int paramIdReserva, int paramIdUsuario, DateTime paramFechaReserva, bool paramEstado)
        {

            MetodosConsultas.EjecutarSinQuery("ReservacionesActualizar",usuario,contraseña,
                "@IdReserva", paramIdReserva,
                "@IdUsuario", paramIdUsuario,
                "@FechaReserva",paramFechaReserva,
                "@Estado", paramEstado);

        }
        public static void EliminarReserva(string usuario,string contraseña,int paramId)
        {
            try
            {
                MetodosConsultas.EjecutarSinQuery("ReservacionesEliminar",usuario,contraseña,
                    "@IdReserva", paramId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static Reservas ObtenerReservaPorId(string usuario,string contraseña,int paramId)
        {
            try
            {
                DataSet dsReservas = MetodosConsultas.EjecutarDataSet("ReservasBuscarPorId", "@IdReserva",usuario,contraseña, paramId);
                if (dsReservas.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsReservas.Tables[0].Rows[0];
                    Reservas Reserva = new Reservas(dr);
                    return Reserva;
                }
                else
                {
                    Reservas Reserva = new Reservas();
                    return Reserva;
                }
            }
            catch (Exception ex) { throw; }
        }
    }
}
