using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlDb
{
    //Source:https://www.youtube.com/watch?v=Qdu-92t15Bs
    //Steps
    //1-Pomelo.EntityFrameworkCore.MySql (5.0.0-alpha.2)
    //2-Pomelo.EntityFrameworkCore.MySql.Design
    //3-Scaffold-DbContext "server=localhost;port=3306;database=HerkDeStadDbTest;user=root;password=Plpl9633++" Pomelo.EntityFrameworkCore.MySql
    //Microsoft.Bcl.AsyncInterfaces
    //Packages:Microsoft.EntityFrameworkCore
    public class MySqlContext:DbContext
    {
        public DbSet<Inschrijving> Inschrijving { get; set; }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {

        }


        
    }
}
