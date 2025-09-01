using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment_01.Inheiratence_Models
{
    internal class Full_time_Employee : Employee
    {
        public decimal Salary { get; set; }
        public  DateOnly StartDate { get; set; }
    }
}
