using EF_Core_Assignment_01.Inheiratence_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment_01.Contexts
{
    internal class Inheirtance_DbContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HASSANALLAM\\SQLEXPRESS;Database = Inheirtance;Trusted_Connection=True; TrustServerCertificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //odelBuilder.Entity<Full_time_Employee>()
            //   .HasBaseType<Employee>();
            //
            //odelBuilder.Entity<Part_time_Employee>()
            //   .HasBaseType<Employee>();

            modelBuilder.Entity<Full_time_Employee>().ToTable("Full Time Employee");
            modelBuilder.Entity<Part_time_Employee>().ToTable("Part Time Employee");
        }

       public DbSet<Full_time_Employee> Full_Time_Employees { get; set; }
       public DbSet<Part_time_Employee> Part_Time_Employees { get; set; }
       public DbSet<Employee> Employees { get; set; }
    }
}
