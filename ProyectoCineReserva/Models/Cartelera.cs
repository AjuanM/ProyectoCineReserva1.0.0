using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCineReserva.Models
{
    public class Cartelera
    {
        public int idCartelera { get; set; }
        public string horaInicio { get; set; }
        public string horaFin { get; set; }
        public  Pelicula pelicula { get; set; }
        public DateTime fecha { get; set; }
        public double precio { get; set; }

    }
}