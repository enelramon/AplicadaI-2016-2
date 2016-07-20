using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

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

        //[Browsable(false)]
        public virtual ICollection<Peliculas> Peliculas { get; set; }

        public Autores(int autorId, string nombres)
        {
            this.AutorId = autorId;
            this.Nombres = nombres;
            this.Peliculas = new HashSet<Peliculas>();
        }
    }
}
