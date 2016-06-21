using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Entidades
{
    public class Autores
    {
        public Autores()
        {
            this.Peliculas = new HashSet<Peliculas>();
        }

        [Key]
        public int AutorId { get; set; }
        public string Nombres { get; set; }
        public virtual ICollection<Peliculas> Peliculas { get; set; }
    }
}
