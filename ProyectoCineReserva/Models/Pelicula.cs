using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCineReserva.Models
{
    public class Pelicula
    {
        public int idPelicula { get; set; }
        public string Titulo { get; set; }
        public string TituloOriginal { get; set; }
        public string  Duracion { get; set; }
        public string Pais { get; set; }
        public string Sinopsis { get; set; }


        public string Censura { get; set; }
        public string ListaActores { get; set; }
        public string Genero { get; set; }
        public string Estado { get; set; }
        public string Idioma { get; set; }


        public string Subtitulos { get; set; }
        public byte[] Imagen { get; set; }
        
        
    }
}