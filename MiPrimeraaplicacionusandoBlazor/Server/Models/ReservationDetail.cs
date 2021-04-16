using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class ReservationDetail
    {
        public int Id { get; set; }
        public int? ReserveId { get; set; }
        public int? BookId { get; set; }
        public int? Quantity { get; set; }
        public int? Active { get; set; }
    }
}
