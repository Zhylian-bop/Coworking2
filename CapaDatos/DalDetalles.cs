using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDatos
{
    public class DalDetalles
    {
        public static List<Detalles> ObtenerDetalles(string usuario, string contrasñea)
        {
            try
            {
                DataSet DsDetalles;
                DsDetalles = MetodosConsultas.EjecutarDataSet("DetallesListar",usuario,contrasñea);
                List<Detalles> ListaDetalles = new List<Detalles>();
                foreach (DataRow Dr in DsDetalles.Tables[0].Rows)
                {
                    ListaDetalles.Add(new Detalles(Dr));
                }
                return ListaDetalles;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void InsertarDetalles(string usuario, string contraseña,int paramIdReserva, int paramIdEspacio, int paramIdServicio, decimal paramTotal, DateTime paramFechaUso, DateTime paramHoraEntrada, DateTime paramHoraSalida)
        {
            try
            {
                MetodosConsultas.EjecutarSinQuery("DetallesInsertar",usuario,contraseña,
                    "@IdReserva", paramIdReserva,
                    "@IdEspacio", paramIdEspacio,
                    "@IdServicio", paramIdServicio,
                    "@Total", paramTotal,
                    "@FechaUso", paramFechaUso,
                    "@HoraEntrada", paramHoraEntrada,
                    "@HoraSalida", paramHoraSalida);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void ActualizarDetalles(string usuario, string contraseña,int paramIdDetalles,int paramIdReserva, int paramIdEspacio, int paramIdServicio, decimal paramTotal, DateTime paramFechaUso, DateTime paramHoraEntrada, DateTime paramHoraSalida)
        {

            MetodosConsultas.EjecutarSinQuery("DetallesActualizar",usuario,contraseña,
                "@IdDetalle", paramIdDetalles, 
                "@IdReserva", paramIdReserva,
                 "@IdEspacio", paramIdEspacio,
                 "@IdServicio", paramIdServicio,
                 "@Total", paramTotal,
                 "@FechaUso", paramFechaUso,
                 "@HoraEntrada", paramHoraEntrada,
                 "@HoraSalida", paramHoraSalida);

        }
        public static void EliminarDetalles(string usuario, string contraseña,int paramId)
        {
            try
            {
                MetodosConsultas.EjecutarSinQuery("DetallesEliminar",usuario,contraseña,
                    "@IdDetalles", paramId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static Detalles ObtenerDetallesPorId(string usuario, string contraseña,int paramId)
        {
            try
            {
                DataSet dsDetalles = MetodosConsultas.EjecutarDataSet("DetallesBuscarPorId",usuario,contraseña, "@IdEmpleado", paramId);
                if (dsDetalles.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsDetalles.Tables[0].Rows[0];
                    Detalles Detalle = new Detalles(dr);
                    return Detalle;
                }
                else
                {
                    Detalles Detalle = new Detalles();
                    return Detalle;
                }
            }
            catch (Exception ex) { throw; }
        }
    }
}
