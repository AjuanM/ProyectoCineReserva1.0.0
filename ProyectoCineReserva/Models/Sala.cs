using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCineReserva.Models
{
    public class Sala
    {
        public int idSala { get; set; }
        public int Aforo { get; set; }
        public int nroPiso { get; set; }
        public Cine cine { get; set; }
    }
}

