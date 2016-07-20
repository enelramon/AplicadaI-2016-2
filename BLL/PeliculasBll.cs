using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public static  class PeliculasBll
    {
        public static bool Insertar(Peliculas pelicula)
        {
            bool retorno = false;
            try
            {
                using (var db = new MoviesDb())
                {
                    db.Peliculas.Add(pelicula);
                    db.SaveChanges();
                    retorno = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return retorno;
        }

        public static Peliculas Buscar(int idPelicula)
        {
            var db = new MoviesDb();

            return db.Peliculas.Find(idPelicula);

        }

        public static List<Peliculas> GetLista()
        {
            List<Peliculas> lista = new List<Peliculas>();

            var db = new MoviesDb();

            lista = db.Peliculas.Where(p => p.CategoriaId==1) .ToList();

            return lista;

        }
    }
}
