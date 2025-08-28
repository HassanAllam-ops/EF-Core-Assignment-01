using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment_01.Models
{
    #region class Instructor
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string? Address { get; set; }
        public int HourRate { get; set; }

        [InverseProperty(nameof(Department.Manger))]
        public virtual Department? ManagedDepartment { get; set; }
        public int DepartmentId { get; set; }

        [InverseProperty(nameof(Department.Instructors))]
        public virtual Department? InstructorDepartment { get; set; }
        public virtual ICollection<CourseInstructor> InstructorCourses { get; set; } = new List<CourseInstructor>();
    }
    #endregion
}
