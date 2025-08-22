using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment_01.Models
{
    #region class StudentCourse
    internal class StudentCourse
    {
      
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Grade { get; set; }
        public int TakesId { get; set; }
        public List<Student> Have { get; set; }
    }
    #endregion
}
