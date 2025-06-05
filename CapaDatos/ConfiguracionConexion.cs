using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConfiguracionConexion
    {
        private static readonly string _CadenaConexionUniversal = @"Server=localhost\SQLEXPRESS;Database=Coworking;Trusted_Connection=True;";

        public static string ObtenerCadenaConexion(string usuario, string contraseña)
        {
                return _CadenaConexionUniversal;  // Usa la cadena universal si no hay credenciales
        }
    }

}
