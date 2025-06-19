using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestionDeGastosMensuales.Models;
namespace GestionDeGastosMensuales.Data
{
    internal class GastosDbContext : DbContext
    {
        public DbSet<Gasto> Gastos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=gastos.db");
        }
    }
}
