using System;
using System.Collections.Generic;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class Person
    {
        public int Id { get; set; }
        public string PersonName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Eposta { get; set; }
        public DateTime? BirthDay { get; set; }
        public int? Active { get; set; }
    }
}
