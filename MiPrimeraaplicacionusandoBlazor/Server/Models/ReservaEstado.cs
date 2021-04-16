using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class ReservaEstado
    {
        public ReservaEstado()
        {
            ReservaHistorials = new HashSet<ReservaHistorial>();
            Reservas = new HashSet<Reserva>();
        }

        public int Iidestadoreserva { get; set; }
        public string Vnombre { get; set; }
        public string Vdescripcion { get; set; }
        public int? Bhabilitado { get; set; }

        public virtual ICollection<ReservaHistorial> ReservaHistorials { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
