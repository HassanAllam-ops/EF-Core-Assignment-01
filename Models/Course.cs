using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment_01.Models
{
    #region Class Course
    public class Course
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int TopicId { get; set; }
        public virtual Topic Topics { get; set; }
        public virtual ICollection<StudentCourse> CourseStudents { get; set; } = new List<StudentCourse>();
        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; } = new List<CourseInstructor>();
    }
    #endregion

}
