using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCineReserva.Models
{
    public class Butaca
    {
        public int idButaca { get; set; }
        public Sala sala { get; set; }
        public bool estado { get; set; }
        public int nroButaca { get; set; }

    }
}