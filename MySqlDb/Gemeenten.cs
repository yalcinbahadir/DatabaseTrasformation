using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDb
{
    public partial class Gemeenten
    {
        public string Deelgemeente { get; set; }
        public string Fusiegemeente { get; set; }
        public string Postcode { get; set; }
        public string Postnummer { get; set; }
        public string Niscode { get; set; }
        public float? Id { get; set; }
        public float? Land { get; set; }
        public string Recordtype { get; set; }
    }
}
