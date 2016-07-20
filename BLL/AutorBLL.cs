using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class AutorBLL
    {

        public static List<Autores> GetLista()
        {
            List<Autores> lista = new List<Autores>();

            var db = new MoviesDb();

            lista = db.Autores.ToList();

            return lista;

        }
    }
}
