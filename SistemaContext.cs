using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGradil
{
    public class SistemaContext : DbContext
    {
        public SistemaContext() : base()
        {
            Database.EnsureCreated();
        }

        public DbSet<CercaRepository> Cercas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite(ConfigurationManager.AppSettings["ConnectionStringDb"]);
            optionsBuilder.UseSqlite("Data Source =" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "dados.db");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CercaRepository>().HasKey(t => t.Id);            
        }
    }
}
