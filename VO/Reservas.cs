using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Reservas
    {
        public int IdReserva {  get; set; }
        public int IdUsuario {  get; set; }
        public DateTime FechaReserva { get; set; }
        public bool Estado {  get; set; }

        public Reservas(DataRow Dr) {
            IdReserva = int.Parse(Dr["IdReserva"].ToString());
            IdUsuario = int.Parse(Dr["IdUsuario"].ToString());
            FechaReserva = DateTime.Parse(Dr["FechaReserva"].ToString());
            Estado = bool.Parse(Dr["Estado"].ToString());
        }
        public Reservas() {
            IdReserva = 0;
            IdUsuario = 0;
            FechaReserva = DateTime.MinValue;
            Estado = false;
        }

    }
}
