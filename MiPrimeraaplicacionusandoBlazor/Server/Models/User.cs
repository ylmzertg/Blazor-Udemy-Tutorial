using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public int? PersonId { get; set; }
        public int? Active { get; set; }
        public int? UserTypeId { get; set; }
    }
}
