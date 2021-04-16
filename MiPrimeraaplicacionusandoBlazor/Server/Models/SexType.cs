using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class SexType
    {
        public int Id { get; set; }
        public string SexTypeName { get; set; }
        public int? Active { get; set; }
    }
}
