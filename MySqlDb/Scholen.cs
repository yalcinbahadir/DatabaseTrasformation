using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDb
{
    public partial class Scholen
    {
        public int Id { get; set; }
        public string Instellingsnummer { get; set; }
        public int? Scholengemeenschap { get; set; }
        public string Naam { get; set; }
        public string Telefoon { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Www { get; set; }
        public string Straat { get; set; }
        public string Nr { get; set; }
        public string Bus { get; set; }
        public int? GemeenteId { get; set; }
        public string Postcode { get; set; }
        public string Gemeente { get; set; }
        public string Typeonderwijs { get; set; }
    }
}
