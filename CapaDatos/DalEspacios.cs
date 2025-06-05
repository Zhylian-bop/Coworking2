using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDatos
{
    public class DalEspacios
    {
        public static List<Espacios> ObtenerEspacios(string usuario, string contraseña)
        {
            try
            {
                DataSet DsuSuarios;
                DsuSuarios = MetodosConsultas.EjecutarDataSet("EspaciosListar",usuario,contraseña);
                List<Espacios> ListaEspacios= new List<Espacios>();
                foreach (DataRow Dr in DsuSuarios.Tables[0].Rows)
                {
                    ListaEspacios.Add(new Espacios(Dr));
                }
                return ListaEspacios;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void InsertarEspacios(string usuario, string contraseña,string paramNombreEspacio, string paramUbicacion, int paramCapacidad, decimal paramPrecio, int paramEncargadoId)
        {
            try
            {
                MetodosConsultas.EjecutarSinQuery("EmpleadosInsertar",usuario,contraseña,
                    "@NombreEspacio", paramNombreEspacio,
                    "@Ubicacion", paramUbicacion,
                    "@Capacidad", paramCapacidad,
                    "@Precio", paramPrecio,
                    "@EncargadoId",paramEncargadoId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void ActualizarEspacio(string usuario, string contraseña,int paramId, string paramNombreEspacio, string paramUbicacion, int paramCapacidad, decimal paramPrecio, int paramEncargadoId)
        {

            MetodosConsultas.EjecutarSinQuery("EspaciosActualizar",usuario,contraseña,
                "@IdEspacio", paramId,
                "@NombreEspacio", paramNombreEspacio,
                "@Ubicacion", paramUbicacion,
                "@Capacidad", paramCapacidad,
                "@Precio", paramPrecio,
                "@EncargadoId", paramEncargadoId);

        }
        public static void EliminarEspacio(string usuario, string contraseña, int paramId)
        {
            try
            {
                MetodosConsultas.EjecutarSinQuery("EspaciossEliminar",
                    "@IdEspacio",usuario,contraseña, paramId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static Espacios ObtenerEspacioPorId(string usuario, string contraseña,int paramId)
        {
            try
            {
                DataSet dsEspacios = MetodosConsultas.EjecutarDataSet("EspaciosBuscarPorId",usuario,contraseña, "@IdEspacio", paramId);
                if (dsEspacios.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsEspacios.Tables[0].Rows[0];
                    Espacios Espacio = new Espacios(dr);
                    return Espacio;
                }
                else
                {
                    Espacios Espacio= new Espacios();
                    return Espacio;
                }
            }
            catch (Exception ex) { throw; }
        }
    }
}
