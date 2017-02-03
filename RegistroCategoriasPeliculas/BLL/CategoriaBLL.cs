using RegistroCategoriasPeliculas.DAL;
using RegistroCategoriasPeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RegistroCategoriasPeliculas.BLL
{
    public class CategoriaBLL
    {

        public static bool Guardar(Categoria categoria)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    db.Categorias.Add(categoria);
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

        public static bool Eliminar(Categoria categoria)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    db.Entry(categoria).State = EntityState.Deleted;
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

        public static Categoria Buscar(int id)
        {
            var categoria = new Categoria();
            using (var db = new PeliculasDb())
            {
                try
                {
                    categoria = db.Categorias.Find(id);
                }
                catch (Exception)
                {
                    throw;
                }
                return categoria;
            }
        }

        public static List<Categoria> GetList()
        {
            List<Categoria> lista = new List<Categoria>();
            using (var db = new PeliculasDb())
            {
                try
                {
                    if (db.Categorias.ToList().Count > 0)
                    {
                        lista = db.Categorias.ToList();
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
