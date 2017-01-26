using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroCategoriasPeliculas.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nombre, string clave)
        {
            Nombre = nombre;
            Clave = clave;
        }
    }
}
