using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDb
{
    public partial class Wisaresult
    {
        public int Id { get; set; }
        public int Rowid { get; set; }
        public int? Wisanr { get; set; }
        public string Error { get; set; }
    }
}
