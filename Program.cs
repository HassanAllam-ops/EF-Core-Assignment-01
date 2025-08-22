using EF_Core_Assignment_01.Contexts;
using Microsoft.EntityFrameworkCore;

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
        }
    }
}
