using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data.Models;

namespace University.Data
{
    public class UniversityContext:  DbContext
    {
        public UniversityContext() : base()
        {

        }

        public DbSet<UniversityClass> Universities { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Major> Majors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=STUDENT20;Initial Catalog=DatabaseFirst;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}
