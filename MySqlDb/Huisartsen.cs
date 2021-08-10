using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDb
{
    public partial class Huisartsen
    {
        public int? Id { get; set; }
        public string Naam { get; set; }
        public string Straat { get; set; }
        public string Telefoonnr { get; set; }
    }
}
