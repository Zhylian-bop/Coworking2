using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MetodosConsultas
    {
        public static DataSet EjecutarDataSet(string sp, string usuario, string contraseña, params object[] Parametros)
        {
            DataSet dataSet = new DataSet();
            string cadenaConexion = ConfiguracionConexion.ObtenerCadenaConexion(usuario, contraseña);

            using (SqlConnection Conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    using (SqlCommand comando = new SqlCommand(sp, Conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        if (Parametros != null && Parametros.Length % 2 != 0)
                        {
                            throw new ApplicationException("Todos los campos deben ser llenados correctamente");
                        }

                        for (int i = 0; i < Parametros.Length; i += 2)
                        {
                            comando.Parameters.AddWithValue(Parametros[i].ToString(), Parametros[i + 1]);
                        }

                        Conexion.Open();
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(dataSet);
                        }
                    }
                    return dataSet;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error en la ejecución: " + ex.Message);
                }
            }
        }
        public static int EjecutarSinQuery(string sp, string usuario, string contraseña, params object[] Parametros)
        {
            int exito = 0;
            string cadenaConexion = ConfiguracionConexion.ObtenerCadenaConexion(usuario, contraseña);

            using (SqlConnection Conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    Conexion.Open();
                    using (SqlCommand Comando = new SqlCommand(sp, Conexion))
                    {
                        Comando.CommandType = CommandType.StoredProcedure;

                        if (Parametros != null && Parametros.Length % 2 != 0)
                        {
                            throw new ApplicationException("Los parámetros no pueden ir vacíos, favor de verificar.");
                        }
                        else
                        {
                            for (int i = 0; i < Parametros.Length; i += 2)
                            {
                                Comando.Parameters.AddWithValue(Parametros[i].ToString(), Parametros[i + 1]);
                            }

                            Comando.ExecuteNonQuery();
                            exito = 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Se produjo un error: " + ex.Message);
                }
            }

            return exito;
        }


    }
}
