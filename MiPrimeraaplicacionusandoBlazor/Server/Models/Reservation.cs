using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class Reservation
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? BookNumber { get; set; }
        public int? ReservationStatus { get; set; }
        public DateTime? ReservationDate { get; set; }
        public DateTime? ReservationEndDate { get; set; }
        public int? Active { get; set; }
    }
}
