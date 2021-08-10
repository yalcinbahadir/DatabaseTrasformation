using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDb
{
    public partial class TblGemeente
    {
        public int? GmId { get; set; }
        public int? GmVeranderddoor { get; set; }
        public string GmVeranderdop { get; set; }
        public string GmPostcode { get; set; }
        public string GmPostnummer { get; set; }
        public string GmDeelgemeente { get; set; }
        public string GmFusiegemeente { get; set; }
        public string GmNiscode { get; set; }
        public int? GmLandFk { get; set; }
        public string GmRecordtype { get; set; }
    }
}
