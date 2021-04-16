using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class UserPageButtonType
    {
        public int Id { get; set; }
        public int? UserPageTypeId { get; set; }
        public int? ButtonId { get; set; }
        public int? Active { get; set; }
    }
}
