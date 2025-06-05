using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Espacios
    {
        public int IdEspacio {  get; set; }
        public int IdEncargado {  get; set; }
        public string NombreEspacio { get; set; }
        public string Direccion{get; set;}
        public int Capacidad { get; set;}
        public decimal CostoEspacio { get; set;}
        public Espacios(DataRow Dr) { 
            IdEspacio = int.Parse(Dr["IdEspacio"].ToString());
            IdEncargado = int.Parse(Dr["IdEncargado"].ToString()) ;
            NombreEspacio = Dr["NombreEspacio"].ToString();
            Capacidad = int.Parse(Dr["Capacidad"].ToString());
            CostoEspacio = decimal.Parse(Dr["CostoEspacio"].ToString() );
        }
        public Espacios() {
            IdEspacio = 0;
            IdEncargado = 0;
            NombreEspacio = string.Empty;
            Direccion = string.Empty;
            Capacidad = 0;
            CostoEspacio = 0;
        }
    }
    
}
