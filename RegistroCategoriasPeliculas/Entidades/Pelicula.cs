using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroCategoriasPeliculas.Entidades
{
    public class Pelicula
    {
        public int PeliculaId { get; set; }
        public DateTime Estreno { get; set; }
        public string Descripcion { get; set; }
        public Categoria Categoria { get; set; }

        public Pelicula()
        {

        }

        public Pelicula(DateTime estreno, string descripcion, Categoria categoria)
        {
            Estreno = estreno;
            Descripcion = descripcion;
            Categoria = categoria;
        }
    }
}
