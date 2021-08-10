using Microsoft.EntityFrameworkCore;
using MySqlDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSqlDb
{
    public class MsSqlContext: DbContext
    {
        public DbSet<Inschrijving> Inschrijvings { get; set; }
        private HerkDeStadDbTestContext _HerkDeStadDbTestContext;
        public MsSqlContext(DbContextOptions<MsSqlContext> options, HerkDeStadDbTestContext HerkDeStadDbTestContext) :base(options)
        {
            _HerkDeStadDbTestContext = HerkDeStadDbTestContext;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inschrijving>().HasData(_HerkDeStadDbTestContext.Inschrijving.ToList());
            base.OnModelCreating(modelBuilder);
        }
    }
}
