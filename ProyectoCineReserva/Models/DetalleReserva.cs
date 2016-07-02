using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCineReserva.Models
{
    public class DetalleReserva
    {
        public int idDetalleReserva { get; set; }
        public Reserva reserva { get; set; }
        public Butaca butaca { get; set; }

        public double precio { get; set; }

    }
}