using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class UserType
    {
        public int Id { get; set; }
        public string UserTypeName { get; set; }
        public string Description { get; set; }
        public int? Active { get; set; }
    }
}
