using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDatos
{
    public class DalServicios
    {
        public static List<Servicios> ObtenerServicios(string usuario, string contraseña)
        {
            try
            {
                DataSet DsServicios;
                DsServicios = MetodosConsultas.EjecutarDataSet("ServiciosListar",usuario,contraseña);
                List<Servicios> ListaServicios = new List<Servicios>();
                foreach (DataRow Dr in DsServicios.Tables[0].Rows)
                {
                    ListaServicios.Add(new Servicios(Dr));
                }
                return ListaServicios;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void InsertarServicio(string usuario,string contraseña,string paramServicio, string paramDescripcion, decimal paramCosto)
        {
            try
            {
                MetodosConsultas.EjecutarSinQuery("ServiciosInsertar",usuario, contraseña,
                    "@Servicio", paramServicio,
                    "@Descripcion", paramDescripcion,
                    "@CostoAdiciona",paramCosto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void ActualizarServicio(string usuario, string contraseña,int paramId, string paramServicio, string paramDescripcion, decimal paramCosto)
        {

            MetodosConsultas.EjecutarSinQuery("ServiciosActualizar", usuario,contraseña,
                "@IdServicio", paramId,
                "@Servicio", paramServicio,
                "@Descripcion", paramDescripcion,
                "@CostoAdiciona", paramCosto);

        }
        public static void EliminarServicio(string usuario, string contraseña,int paramId)
        {
            try
            {
                MetodosConsultas.EjecutarSinQuery("ServiciosEliminar",usuario,contraseña,
                    "@IdServicio", paramId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static Servicios ObtenerServicioPorId(string usuario, string contraseña,int paramId)
        {
            try
            {
                DataSet dsServicios = MetodosConsultas.EjecutarDataSet("ServiciosBuscarPorId",usuario,contraseña, "@IdServicio", paramId);
                if (dsServicios.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsServicios.Tables[0].Rows[0];
                    Servicios Servicio = new Servicios(dr);
                    return Servicio;
                }
                else
                {
                    Servicios Servicio = new Servicios();
                    return Servicio;
                }
            }
            catch (Exception ex) { throw; }
        }
    }
}
