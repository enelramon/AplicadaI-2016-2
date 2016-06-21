using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public static class CategoriasBll
    {
        public static bool Insertar(Categorias Categoria)
        {
            bool retorno = false;
            try
            {
                using (var db = new MoviesDb())
                {
                    db.Categorias.Add(Categoria);
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

        public static Categorias Buscar(int IdCategoria)
        {
            var db = new MoviesDb();

            return db.Categorias.Find(IdCategoria);

        }
    }
}
