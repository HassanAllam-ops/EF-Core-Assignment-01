using EF_Core_Assignment_01.Contexts;
using EF_Core_Assignment_01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EF_Core_Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
         using ITIDbContext context = new ITIDbContext();
            #region CURD Operations
            #region Add (Create) 
            //Student Std1 = new Student()
            //{
            //    Fname = "Ahmed",
            //    Lname = "Ali",
            //    Age = 22,
            //    Address = "Cairo"
            //};
            //
            //Student Std2 = new Student()
            //{
            //    Fname = "Sara",
            //    Lname = "Mohamed",
            //    Age = 21,
            //    Address = "Alex"
            //};
            //
            //Console.WriteLine($"Student 01 : {context.Entry(Std1).State}");
            //Console.WriteLine($"Student 02 : {context.Entry(Std2).State}");
            //
            //context.Add(Std1);
            //context.Add(Std2);
            //
            //Console.WriteLine($"Student 01 : {context.Entry(Std1).State}");
            //Console.WriteLine($"Student 02 : {context.Entry(Std2).State}");
            //
            //context.SaveChanges();
            #endregion

            #region Select (Read)
            //var Result = (from S in context.Students
            //              where S.Fname == "Ahmed"
            //              select S).AsTracking().FirstOrDefault();
            //
            //Console.WriteLine($"Student Name : {Result.Lname}");
            #endregion

            #region Update (Modify)
            //var Result = (from S in context.Students
            //             where S.Fname == "Ahmed"
            //             select S).FirstOrDefault();
            //
            //if (Result != null)
            //{
            //    Console.WriteLine($"Student Name : {Result.Lname}");
            //
            //    Result.Lname = "Hassan";
            //
            //    Console.WriteLine($"Student Name : {Result.Lname}");
            //    context.SaveChanges();
            //}

            #endregion

            #region Remove (Delete)
            //var Result = (from S in context.Students
            //            where S.Fname == "Ahmed"
            //             select S).FirstOrDefault();
            //
            //context.Students.Remove(Result);
            //context.SaveChanges();
            #endregion
            #endregion

            #region Manual Data Seeding
            //List<Student> Students = new List<Student>()
            //{
            //    new Student()
            //    {
            //        
            //        Fname = "Ahmed",
            //        Lname = "Ali",
            //        Age = 22,
            //        Address = "Cairo",
            //        
            //    },
            //    new Student()
            //    {
            //       
            //        Fname = "Sara",
            //        Lname = "Mohamed",
            //        Age = 21,
            //        Address = "Alex",
            //        
            //    },
            //    new Student()
            //    {
            //        
            //        Fname = "Omar",
            //        Lname = "Youssef",
            //        Age = 23,
            //        Address = "Giza",
            //        
            //    },
            //    new Student()
            //    {
            //       
            //        Fname = "Mona",
            //        Lname = "Saeed",
            //        Age = 20,
            //        Address = "Tanta",
            //        
            //    }
            //};
            ////List<Department> Departments = new List<Department>()
            //{
            //    new Department()
            //    {
            //        Name = "CS"
            //    },
            //    new Department()
            //    {
            //        Name = "IS"
            //    },
            //    new Department()
            //    {
            //        Name = "IT"
            //    }
            //};
            //context.Set<Student>().AddRange(Students);
            //context.Set<Department>().AddRange(Departments);
            //context.SaveChanges();
            #endregion

            #region Eager Loading
            //var Std01 = context.Students.Include(S => S.Department)
            //    .FirstOrDefault(S => S.Id == 2);
            //
            //if (Std01 != null)
            //{
            //    Console.WriteLine($"Student First Name : {Std01.Fname}");
            //    Console.WriteLine($"Student Last Name : {Std01.Lname}");
            //    Console.WriteLine($"Department Id : {Std01.DepartmentId}");
            //    Console.WriteLine($"Department Name : {Std01.Department?.Name}");
            //}
            #endregion

            #region Explicit Loading
            //var Std01 = context.Students.FirstOrDefault(S => S.Id == 2);
            //
            //if (Std01 != null)
            //{
            //    Console.WriteLine($"Student First Name : {Std01.Fname}");
            //    Console.WriteLine($"Student Last Name : {Std01.Lname}");
            //    Console.WriteLine($"Department Id : {Std01.DepartmentId}");
            //    context.Entry(Std01).Reference(S => S.Department).Load();
            //    Console.WriteLine($"Department Name : {Std01.Department?.Name}");
            //}
            #endregion

            #region Lazy Loading
            //var Std01 = context.Students.FirstOrDefault(S => S.Id == 2);
            //
            //if (Std01 != null)
            //{
            //    Console.WriteLine($"Student First Name : {Std01.Fname}");
            //    Console.WriteLine($"Student Last Name : {Std01.Lname}");
            //    Console.WriteLine($"Department Id : {Std01.DepartmentId}");
            //    Console.WriteLine($"Department Name : {Std01.Department?.Name}");
            //}
            #endregion
        }
    }
}
