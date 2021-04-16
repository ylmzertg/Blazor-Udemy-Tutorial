using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public int? Active { get; set; }
    }
}
