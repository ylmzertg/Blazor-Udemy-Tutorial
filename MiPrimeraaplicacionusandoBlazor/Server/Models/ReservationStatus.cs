using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class ReservationStatus
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Description { get; set; }
        public int? Active { get; set; }
    }
}
