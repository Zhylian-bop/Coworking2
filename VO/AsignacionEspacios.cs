using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class AsignacionEspacios
    {
        public int IdAsignacion { get; set; }
        public int IdEspacio { get; set; }
        public int IdEmpleado { get; set; }

        public AsignacionEspacios(DataRow Dr) {
            IdAsignacion = int.Parse(Dr["Idasignacion"].ToString());
            IdEspacio = int.Parse(Dr["IdEspacio"].ToString());
            IdAsignacion = int.Parse(Dr["Idasignacion"].ToString());
        }
        public AsignacionEspacios() {
            IdAsignacion = 0;
            IdEspacio = 0;
            IdEmpleado = 0;
        }
    }
}
