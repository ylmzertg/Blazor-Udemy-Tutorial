using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public int? PageNumber { get; set; }
        public int? Stock { get; set; }
        public string BookPdf { get; set; }
        public string CoverPhoto { get; set; }
        public int? Active { get; set; }
        public int? AuthorId { get; set; }
    }
}
