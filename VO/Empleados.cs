using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Empleados
    {
        public int IdEmpleado {  get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoPaternoEmpleado { get; set; }
        public string ApellidoMaternoEmpleado { get; set; }
        public int EdadEmpleado {  get; set; }
        public string Puesto {  get; set; }
        public float Contacto {  get; set; }
        public Empleados(DataRow Dr) {
            IdEmpleado = int.Parse(Dr["IdEmpleado"].ToString());
            NombreEmpleado = Dr["NombreEmpleado"].ToString();
            ApellidoPaternoEmpleado = Dr["ApellidoPaternoEmpleado"].ToString();
            ApellidoMaternoEmpleado = Dr["ApellidoMaternoEmpleado"].ToString() ;
            EdadEmpleado = int.Parse(Dr["EdadEmpleado"].ToString());
            Puesto = Dr["Puesto"].ToString();
            Contacto = float.Parse(Dr["Contacto"].ToString());
        }
        public Empleados() {
            IdEmpleado = 0;
            NombreEmpleado = string.Empty;
            ApellidoPaternoEmpleado = string.Empty;
            ApellidoMaternoEmpleado = string.Empty;
            EdadEmpleado = 0;
            Puesto = string.Empty;
            Contacto = 0;
        }
    }
}
