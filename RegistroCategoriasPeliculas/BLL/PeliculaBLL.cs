using RegistroCategoriasPeliculas.DAL;
using RegistroCategoriasPeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RegistroCategoriasPeliculas.BLL
{
    public class PeliculaBLL
    {

        public static bool Guardar(Pelicula pelicula)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    db.Peliculas.Add(pelicula);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
                return false;
            }
        }

        public static bool Eliminar(Pelicula pelicula)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    db.Entry(pelicula).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
                return false;
            }
        }

        public static Pelicula Buscar(int id)
        {
            var pelicula = new Pelicula();
            using (var db = new PeliculasDb())
            {
                try
                {
                    pelicula = db.Peliculas.Find(id);
                }
                catch (Exception)
                {
                    throw;
                }
                return pelicula;
            }
        }

        public static List<Pelicula> GetList()
        {
            List<Pelicula> lista = new List<Pelicula>();
            using (var db = new PeliculasDb())
            {
                try
                {
                    if (db.Peliculas.ToList().Count > 0)
                    {
                        lista = db.Peliculas.ToList();
                    }
                    else
                    {
                        lista = null;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                return lista;
            }
        }

    }
}
