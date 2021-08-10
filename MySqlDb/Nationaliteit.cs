using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDb
{
    public partial class Nationaliteit
    {
        public int? Id { get; set; }
        public int? Land { get; set; }
        public string Niscode { get; set; }
        public string Omschrijving { get; set; }
        public string Vluchteling { get; set; }
    }
}
