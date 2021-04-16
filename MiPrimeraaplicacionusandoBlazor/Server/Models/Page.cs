using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class Page
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Action { get; set; }
        public int? Active { get; set; }
        public int? Visible { get; set; }
    }
}
