using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment_01.Models
{
    #region class Student
    internal class Student
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string? Lname { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public List<StudentCourse> Takes { get; set; }
    }
    #endregion
}
