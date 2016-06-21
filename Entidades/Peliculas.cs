using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Peliculas
    {
        [Key]
        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Ano { get; set; }
        public int Clasificacion { get; set; }
        public int IMDB { get; set; }
        public int CategoriaId { get; set; }

        public virtual ICollection<Autores> Autores { get; set; }
        
        public virtual Categorias Categorias { get; set; }
    }
}
