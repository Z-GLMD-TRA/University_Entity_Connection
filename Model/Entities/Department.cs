using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Title { get; set; } = string.Empty;

        public  ICollection<Student> Students{ get; set; } = new List<Student>();
        public  ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();

    }
}
