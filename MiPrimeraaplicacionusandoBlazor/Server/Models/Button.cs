using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class Button
    {
        public int Id { get; set; }
        public string ButtonName { get; set; }
        public int? Active { get; set; }
    }
}
