using EF_Core_Assignment_01.Contexts;
using EF_Core_Assignment_01.Inheiratence_Models;
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
            // using ITIDbContext context = new ITIDbContext();
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

            #region Join()
            #region Query Syntax
            //var Result = from D in context.Departments
            //             join S in context.Students
            //             on D.Id equals S.DepartmentId
            //             select new
            //             {
            //                 DepartmentName = D.Name,
            //                 StudentName = S.Fname + " " + S.Lname
            //             };
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Department Name : {item.DepartmentName} - Student Name : {item.StudentName}");
            //}
            #endregion

            #region Fluent Syntax
            //var Result = context.Departments.Join(context.Students,
            //    D => D.Id,
            //    S => S.DepartmentId,
            //    (D, S) => new
            //    {
            //        DepartmentName = D.Name,
            //        StudentName = S.Fname + " " + S.Lname
            //    });
            //
            //
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Department Name : {item.DepartmentName} - Student Name : {item.StudentName}");
            //} 

            #endregion

            #endregion

            #region GroupJoin()

            #region Fluent Syntax
            //var Result = context.Departments.GroupJoin(context.Students,
            //    D => D.Id,
            //    S => S.DepartmentId,
            //    (D, Students) => new
            //    {
            //        DepartmentName = D.Name,
            //        Students
            //    });
            //
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Department Name : {item.DepartmentName}");
            //    foreach (var student in item.Students)
            //    {
            //        Console.WriteLine($"\t Student Name : {student.Fname} {student.Lname}");
            //    }
            #endregion

            #region Query Syntax
            //var Result = from D in context.Departments 
            //                join S in context.Students
            //                on D.Id equals S.DepartmentId
            //                into StudentsGroup
            //                select new
            //                {
            //                    DepartmentName = D.Name,
            //                    StudentsGroup
            //                };
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Department Name : {item.DepartmentName}");
            //    foreach (var student in item.StudentsGroup)
            //    {
            //        Console.WriteLine($"\t Student Name : {student.Fname} {student.Lname}");
            //    }
            //}
            #endregion

            #endregion

            #region Inheritance Mapping
            #region TPC
            //using Inheirtance_DbContext context = new Inheirtance_DbContext();
            //
            //Full_time_Employee FTE = new Full_time_Employee()
            //{
            //    Name = "Ahmed",
            //    Age = 30,
            //    Address = "Cairo",
            //    Salary = 5000,
            //    StartDate = new DateOnly(2020, 1, 1)
            //};
            //
            //Part_time_Employee PTE = new Part_time_Employee()
            //{
            //    Name = "Sara",
            //    Age = 25,
            //    Address = "Alex",
            //    CountHours = 100,
            //    HoursRate = 50
            //};
            //
            ////context.Full_Time_Employees.Add(FTE);
            ////context.Part_Time_Employees.Add(PTE);
            ////Console.WriteLine(context.SaveChanges());
            //
            //var Full = context.Full_Time_Employees.FirstOrDefault();
            //var Part = context.Part_Time_Employees.FirstOrDefault();
            //
            //if (Full != null)
            //{
            //    Console.WriteLine($"Full Time Employee Name : {Full.Name}");
            //    Console.WriteLine($"Full Time Employee Age : {Full.Age}");
            //    Console.WriteLine($"Full Time Employee Address : {Full.Address}");
            //    Console.WriteLine($"Full Time Employee Salary : {Full.Salary}");
            //    Console.WriteLine($"Full Time Employee Start Date : {Full.StartDate}");
            //}
            //
            //else
            //{
            //    Console.WriteLine(
            //        $"Full Time Employee Not Found");
            //}
            //
            //Console.WriteLine("===================================");
            //
            //if ( Part != null )
            //{
            //    Console.WriteLine($"Part Time Employee Name : {Part.Name}");
            //    Console.WriteLine($"Part Time Employee Age : {Part.Age}");
            //    Console.WriteLine($"Part Time Employee Address : {Part.Address}");
            //    Console.WriteLine($"Part Time Employee Salary : {Part.HoursRate}");
            //    Console.WriteLine($"Part Time Employee Start Date : {Part.CountHours}");
            //}
            //
            //else
            //{
            //    Console.WriteLine(
            //       $"Part Time Employee Not Found");
            //}
            #endregion

            #region TPH
            //using Inheirtance_DbContext context = new Inheirtance_DbContext();
            //
            //Full_time_Employee FTE = new Full_time_Employee()
            //{
            //    Name = "Ahmed",
            //    Age = 30,
            //    Address = "Cairo",
            //    Salary = 5000,
            //    StartDate = new DateOnly(2020, 1, 1)
            //};
            //
            //Part_time_Employee PTE = new Part_time_Employee()
            //{
            //    Name = "Sara",
            //    Age = 25,
            //    Address = "Alex",
            //    CountHours = 100,
            //    HoursRate = 50
            //};
            //
            //context.Add( PTE );
            //context.Add(FTE);
            //Console.WriteLine(context.SaveChanges());

            #endregion

            #region TPT
            //using Inheirtance_DbContext context = new Inheirtance_DbContext();
            //
            //Full_time_Employee FTE = new Full_time_Employee()
            //{
            //    Name = "Ahmed",
            //    Age = 30,
            //    Address = "Cairo",
            //    Salary = 5000,
            //    StartDate = new DateOnly(2020, 1, 1)
            //};
            //
            //Part_time_Employee PTE = new Part_time_Employee()
            //{
            //    Name = "Sara",
            //    Age = 25,
            //    Address = "Alex",
            //    CountHours = 100,
            //    HoursRate = 50
            //};
            //
            //context.Add( PTE );
            //context.Add(FTE);
            //Console.WriteLine(context.SaveChanges());
            #endregion
            #endregion

            #region Local
            //using Inheirtance_DbContext context = new Inheirtance_DbContext();

            #region Example 01
            //var Result = context.Employees.Local.Any(E => E.Age != null);
            //Console.WriteLine(Result);
            //Result = context.Employees.Any(E => E.Age != null);
            //Console.WriteLine(Result);
            #endregion

            #region Example 02
            //var Emp01 = context.Employees.FirstOrDefault();
            //if (Emp01 != null)
            //{
            //    Console.WriteLine($"Employee Age : {Emp01.Age}");
            //}
            //
            //var Result = context.Employees.Local.Any(E => E.Age != null);
            //Console.WriteLine(Result);
            //Result = context.Employees.Any(E => E.Age != null);
            //Console.WriteLine(Result);
            #endregion
            #endregion

        }
    }
}





