using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment_01.Inheiratence_Models
{
    internal class Part_time_Employee : Employee
    {
        public int CountHours { get; set; }
        public  double HoursRate { get; set; }
    }
}
