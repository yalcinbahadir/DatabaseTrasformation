using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using MSSqlDb;
using MySqlDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.UI.Pages
{
    public partial class Index
    {
        [Inject]
        public HerkDeStadDbTestContext HerkDeStadDbTestContext { get; set; }
        [Inject]
        public MsSqlContext MsSqlContext { get; set; }
        private async Task Transfer()
        {
            var data=await HerkDeStadDbTestContext.Inschrijving.ToListAsync();
            await MsSqlContext.Inschrijvings.AddRangeAsync(data);
            await MsSqlContext.SaveChangesAsync();
            var result= await MsSqlContext.Inschrijvings.ToListAsync();

        }
    }
}
