using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class PaginaTipoUsuario
    {
        public PaginaTipoUsuario()
        {
            PaginaTipoUsuButtons = new HashSet<PaginaTipoUsuButton>();
        }

        public int Iidpaginatipousuario { get; set; }
        public int? Iidpagina { get; set; }
        public int? Iidtipousuario { get; set; }
        public int? Bhabilitado { get; set; }

        public virtual Pagina IidpaginaNavigation { get; set; }
        public virtual TipoUsuario IidtipousuarioNavigation { get; set; }
        public virtual ICollection<PaginaTipoUsuButton> PaginaTipoUsuButtons { get; set; }
    }
}
