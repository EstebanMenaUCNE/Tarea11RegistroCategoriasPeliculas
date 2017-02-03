using RegistroCategoriasPeliculas.DAL;
using RegistroCategoriasPeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RegistroCategoriasPeliculas.BLL
{
    public class UsuarioBLL
    {

        public static bool Guardar(Usuario usuario)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    db.Usuarios.Add(usuario);
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

        public static bool Eliminar(Usuario usuario)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    db.Entry(usuario).State = EntityState.Deleted;
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

        public static Usuario Buscar(int id)
        {
            var usuario = new Usuario();
            using (var db = new PeliculasDb())
            {
                try
                {
                    usuario = db.Usuarios.Find(id);
                }
                catch (Exception)
                {
                    throw;
                }
                return usuario;
            }
        }

        public static List<Usuario> GetList()
        {
            List<Usuario> lista = new List<Usuario>();
            using (var db = new PeliculasDb())
            {
                try
                {
                    if (db.Usuarios.ToList().Count > 0)
                    {
                        lista = db.Usuarios.ToList();
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
