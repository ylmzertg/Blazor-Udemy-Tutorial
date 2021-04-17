using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class Author
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? SexTypeId { get; set; }
        public int? CountryId { get; set; }
        public string Description { get; set; }
        public int? Active { get; set; }
    }
}
