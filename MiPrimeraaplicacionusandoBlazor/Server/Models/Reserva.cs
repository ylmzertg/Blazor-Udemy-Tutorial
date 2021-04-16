using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class Reserva
    {
        public Reserva()
        {
            DetalleReservas = new HashSet<DetalleReserva>();
            ReservaHistorials = new HashSet<ReservaHistorial>();
        }

        public int Iidreserva { get; set; }
        public int? Iidusuario { get; set; }
        public int? Numlibros { get; set; }
        public int? Iidestadoreserva { get; set; }
        public DateTime? Dfechareserva { get; set; }
        public DateTime? Dfechafinreserva { get; set; }
        public int? Bhabilitado { get; set; }

        public virtual ReservaEstado IidestadoreservaNavigation { get; set; }
        public virtual ICollection<DetalleReserva> DetalleReservas { get; set; }
        public virtual ICollection<ReservaHistorial> ReservaHistorials { get; set; }
    }
}
