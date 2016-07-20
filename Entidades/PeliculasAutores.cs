using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class PeliculasAutores
    { 
        [Key]
        public int Id { get; set; }
        public int PeliculaId { get; set; }

        public int AutorId { get; set; }

        public virtual Peliculas Peliculas { get; set; }
        public virtual Autores Autores { get; set; }
    }
}
