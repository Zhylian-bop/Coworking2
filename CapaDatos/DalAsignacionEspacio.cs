using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDatos
{
    public class DalAsignacionEspacio
    {
        public static List<AsignacionEspacios> ObtenerAsignaciones(string usuario, string contraseña)
        {
            try
            {
                DataSet DsEspacios;
                DsEspacios = MetodosConsultas.EjecutarDataSet("AsignacionListar",usuario,contraseña);
                List<AsignacionEspacios> ListaAsignacion = new List<AsignacionEspacios>();
                foreach (DataRow Dr in DsEspacios.Tables[0].Rows)
                {
                    ListaAsignacion.Add(new AsignacionEspacios(Dr));
                }
                return ListaAsignacion;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void InsertarAsignacion(string usuario,string contraseña,int paramIdEspacio, int paramIdEmpleado)
        {
            try
            {
                MetodosConsultas.EjecutarSinQuery("AsignacionesInsertar",usuario,contraseña,
                    "@IdEspacio", paramIdEspacio,
                    "@IdEmpleado", paramIdEspacio);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void ActualizarAsignacion(string usuario, string contraseña,int paramIdAsignacion,int paramIdEspacio, int paramIdEmpleado)
        {

            MetodosConsultas.EjecutarSinQuery("AsignacionActualizar",usuario,contraseña,
                "@IdAsignacion", paramIdAsignacion,
                "@IdEspacio", paramIdEspacio,
                "@IdEmpleado", paramIdEspacio);

        }
        public static void EliminarAsignacion(string usuario, string contraseña,int paramId)
        {
            try
            {
                MetodosConsultas.EjecutarSinQuery("AsignacionEliminar",usuario,contraseña,
                    "@IdAsignacion", paramId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static AsignacionEspacios ObtenerasignacionPorId(string usuario, string contraseña,int paramId)
        {
            try
            {
                DataSet dsAsignaciones = MetodosConsultas.EjecutarDataSet("AsignacionBuscarPorId",usuario,contraseña, "@IdAsignacion", paramId);
                if (dsAsignaciones.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsAsignaciones.Tables[0].Rows[0];
                    AsignacionEspacios Asignacion = new AsignacionEspacios(dr);
                    return Asignacion;
                }
                else
                {
                    AsignacionEspacios Asignacion = new AsignacionEspacios();
                    return Asignacion;
                }
            }
            catch (Exception ex) { throw; }
        }
    }
}
