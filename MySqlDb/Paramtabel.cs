using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDb
{
    public partial class Paramtabel
    {
        public int? Id { get; set; }
        public int? PId { get; set; }
        public int? PVeranderddoor { get; set; }
        public string PVeranderdop { get; set; }
        public string PRecordtype { get; set; }
        public string PType { get; set; }
        public string PCode { get; set; }
        public string POmschrijving { get; set; }
        public string PExtra { get; set; }
    }
}
