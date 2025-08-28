using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment_01.Models
{
    #region Class CourseInstructor
    public class CourseInstructor
    {
        
        public int InstractorId { get; set; }
        public int CourseId { get; set; }
        public int Evaluate { get; set; }
        public virtual Course Courses { get; set; }
        public virtual Instructor Instructors { get; set; }
    }
    #endregion
}
