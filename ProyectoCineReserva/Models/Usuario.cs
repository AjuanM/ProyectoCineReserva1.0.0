using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCineReserva.Models
{
    public class Usuario
    {

        public int idUsuario { get; set; }
        public string Nombre { get; set; }
        public string  Apellido { get; set; }

        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Dni { get; set; }
        public string userName { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }

    }
}