using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment_01.Models
{
    #region Class CourseInstructor
    internal class CourseInstructor
    {
        
        public int InstractorId { get; set; }
        public int CourseId { get; set; }
        public int Evaluate { get; set; }
        public Course HaveCourses { get; set; }
        public Instructor HaveInstructors { get; set; }
    }
    #endregion
}
