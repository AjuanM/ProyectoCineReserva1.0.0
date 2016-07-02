using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCineReserva.Models
{
    public class Reserva
    {

        public int idReserva { get; set; }

        public Usuario usuario { get; set; }
        public double montoTotal  { get; set; }
        public Cartelera cartelera { get; set; }        
    }
}