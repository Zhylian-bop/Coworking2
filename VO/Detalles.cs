using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Detalles
    {
        public int IdDetalles {  get; set; }
        public int IdReserva {  get; set; }
        public int IdEspacio {  get; set; }
        public int IdServicio {  get; set; }
        public decimal Total {  get; set; }
        public DateTime FechaUso { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }

        public Detalles(DataRow Dr) {
            IdDetalles = int.Parse(Dr["IdDetalles"].ToString());
            IdReserva = int.Parse(Dr["IdReserva"].ToString()) ;
            IdEspacio = int.Parse(Dr["IdEspacio"].ToString() ) ;
            Total = decimal.Parse(Dr["Total"].ToString());
            FechaUso = DateTime.Parse(Dr["FechaUso"].ToString());
            HoraEntrada = DateTime.Parse(Dr["HoraEntrada"].ToString());
            HoraSalida = DateTime.Parse(Dr["HoraSalida"].ToString());
        }
        public Detalles() {
            IdDetalles = 0;
            IdReserva = 0;
            IdEspacio = 0;
            Total = 0;
            FechaUso = DateTime.MinValue;
            HoraEntrada = DateTime.MinValue;
            HoraSalida = DateTime.MinValue;
        }
    }
}
