using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment_01.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string? Address { get; set; }
        public int HourRate { get; set; }
        public int DepartmentId { get; set; }
    }
}
