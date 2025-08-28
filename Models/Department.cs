using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment_01.Models
{
    #region class Department
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? InstructorId { get; set; }
        public DateTime HiringDate { get; set; }

        [InverseProperty(nameof(Instructor.ManagedDepartment))]
        public virtual Instructor? Manger { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();

        [InverseProperty(nameof(Instructor.InstructorDepartment))]
        public virtual ICollection <Instructor> Instructors { get; set; } = new HashSet<Instructor>();
    }
    #endregion
}
