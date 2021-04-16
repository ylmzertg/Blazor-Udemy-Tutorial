using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class ReservationHistory
    {
        public int Id { get; set; }
        public int? ReservationId { get; set; }
        public int? StatusId { get; set; }
        public string Observation { get; set; }
        public int? UserId { get; set; }
        public int? Active { get; set; }
    }
}
