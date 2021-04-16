using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class Pagina
    {
        public Pagina()
        {
            PaginaTipoUsuarios = new HashSet<PaginaTipoUsuario>();
        }

        public int Iidpagina { get; set; }
        public string Mensaje { get; set; }
        public string Accion { get; set; }
        public int? Bhabilitado { get; set; }
        public int? Bvisible { get; set; }

        public virtual ICollection<PaginaTipoUsuario> PaginaTipoUsuarios { get; set; }
    }
}
