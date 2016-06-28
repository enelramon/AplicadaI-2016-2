using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Entidades;

namespace DAL
{
    public class MoviesDb : DbContext
    {
        //You should always use the name= syntax when you are using a connection string in the config file. This ensures that if the connection string is not present then Entity Framework will throw rather than creating a new database by convention.
        public MoviesDb() : base("name=MoviesDb")
        {
        }

        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual  DbSet<Peliculas> Peliculas { get; set; }
        public virtual DbSet<Autores> Autores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
