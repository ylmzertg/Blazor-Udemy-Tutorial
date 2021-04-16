using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            PaginaTipoUsuarios = new HashSet<PaginaTipoUsuario>();
            Usuarios = new HashSet<Usuario>();
        }

        public int Iidtipousuario { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? Bhabilitado { get; set; }

        public virtual ICollection<PaginaTipoUsuario> PaginaTipoUsuarios { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
