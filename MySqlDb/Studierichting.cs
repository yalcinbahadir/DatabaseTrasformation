using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDb
{
    public partial class Studierichting
    {
        public int? Id { get; set; }
        public string Jaar { get; set; }
        public string Richting { get; set; }
        public string Otraject { get; set; }
        public int Keuze { get; set; }
    }
}
