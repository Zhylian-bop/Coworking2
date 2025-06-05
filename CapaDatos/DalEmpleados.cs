using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace CapaDatos
{
    public class DalEmpleados
    {
        public static List<Empleados> ObtenerEmpleados(string usuario, string contraseña) {
            try
            {
                DataSet DsuSuarios;
                DsuSuarios = MetodosConsultas.EjecutarDataSet("EmpleadosListar",usuario,contraseña);
                List<Empleados> ListaEmpleados = new List<Empleados>();
                foreach (DataRow Dr in DsuSuarios.Tables[0].Rows)
                {
                    ListaEmpleados.Add(new Empleados(Dr));
                }
                return ListaEmpleados;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void InsertarEmpleados(string usuario,string contraseña,string paramNombre, string paramApellidoPaterno, string paramApellidoMaterno, int paramEdad, string paramPuesto, float paramTelefono)
        {
            try
            {
                MetodosConsultas.EjecutarSinQuery("EmpleadosInsertar",usuario,contraseña,
                    "@Nombre", paramNombre,
                    "@ApellidoPaterno", paramApellidoPaterno,
                    "@ApellidoMaterno", paramApellidoMaterno,
                    "@Edad", paramEdad,
                    "@Puesto", paramPuesto,
                    "@Contacto", paramTelefono);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void ActualizarEmpleado(string usuario,string contraseña,int paramId, string paramNombre, string paramApellidoPaterno, string paramApellidoMaterno, int paramEdad, string paramPuesto, float paramTelefono)
        {

            MetodosConsultas.EjecutarSinQuery("EmpleadosActualizar",usuario,contraseña,
                "@IdEmpleado", paramId,
                "@NombreUsuario", paramNombre,
                "@ApellidoPaterno", paramApellidoPaterno,
                "@ApellidoMaterno", paramApellidoMaterno,
                "@Edad", paramEdad,
                "@Puesto", paramPuesto,
                "@Contacto", paramTelefono);

        }
        public static void EliminarEmpleado(string usuario, string contraseña,int paramId)
        {
            try
            {
                MetodosConsultas.EjecutarSinQuery("EmpleadosEliminar",usuario,contraseña,
                    "@IdEmpleado", paramId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static Empleados ObtenerEmpleadoPorId(string usuario,string contrañsea,int paramId)
        {
            try
            {
                DataSet dsEmpleados = MetodosConsultas.EjecutarDataSet("EmpleadosBuscarPorId",usuario,contrañsea, "@IdEmpleado", paramId);
                if (dsEmpleados.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dsEmpleados.Tables[0].Rows[0];
                    Empleados Empleado = new Empleados(dr);
                    return Empleado;
                }
                else
                {
                    Empleados Empleado = new Empleados();
                    return Empleado;
                }
            }
            catch (Exception ex) { throw; }
        }
    }
}
