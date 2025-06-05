using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Servicios
    {
        public int Idservicio{get;set;}
        public string Servicio { get; set; }
        public string DescripcionServicio { get; set; }
        public decimal Costo {  get; set; }

        public Servicios(DataRow Dr) { 
            Idservicio = int.Parse(Dr["IdServicio"].ToString());
            Servicio = Dr["Servicio"].ToString();
            DescripcionServicio = Dr["DescripcionServicio"].ToString() ;
            Costo = Decimal.Parse(Dr["Costo"].ToString());
        }
        public Servicios() {
            Idservicio = 0;
            Servicio = string.Empty;
            DescripcionServicio= string.Empty;
            Costo = 0;
        }
    }
}
