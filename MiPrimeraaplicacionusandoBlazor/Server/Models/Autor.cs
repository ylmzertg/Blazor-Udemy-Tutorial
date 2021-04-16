using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class Autor
    {
        public Autor()
        {
            Libros = new HashSet<Libro>();
        }

        public int Iidautor { get; set; }
        public string Nombre { get; set; }
        public string Appaterno { get; set; }
        public string Apmaterno { get; set; }
        public int? Iidsexo { get; set; }
        public int? Iidpais { get; set; }
        public string Descripcion { get; set; }
        public int? Bhabilitado { get; set; }

        public virtual Pai IidpaisNavigation { get; set; }
        public virtual Sexo IidsexoNavigation { get; set; }
        public virtual ICollection<Libro> Libros { get; set; }
    }
}
