using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class UserPageType
    {
        public int Id { get; set; }
        public int? PageId { get; set; }
        public int? UserTypeId { get; set; }
        public int? Active { get; set; }
    }
}
