using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment_01.Models
{
    #region class Topic
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
    #endregion
}
