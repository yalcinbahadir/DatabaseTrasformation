using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDb
{
    public partial class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Type { get; set; }
        public int Actief { get; set; }
        public int Selection { get; set; }
    }
}
