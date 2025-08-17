using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment_01.Models
{
    internal class CourseInstructor
    {
        public int Id { get; set; } // i added id primary key because Migration does not work
        public int InstractorId { get; set; } 
        public int CourseId { get; set; }
        public int Evaluate { get; set; }
    }
}
