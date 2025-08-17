using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Core_Assignment_01.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Assignment_01.Contexts
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITI;Trusted_Connection=True;");
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Topic> Topics { get; set; }    
    }
}
