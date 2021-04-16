using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class BookType
    {
        public int Id { get; set; }
        public string BookTypeName { get; set; }
        public string Description { get; set; }
        public int? Active { get; set; }
    }
}
