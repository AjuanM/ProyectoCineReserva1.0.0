using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCineReserva.Models
{
    public class Cine
    {
        public int idCine { get; set; }
        public string Nombre { get; set; }
        public string Provincia { get; set; }

        public string Direccion { get; set; }
        public int Aforo { get; set; }

        public int nroSalas { get; set; }


    }
}