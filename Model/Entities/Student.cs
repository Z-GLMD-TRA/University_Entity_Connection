using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Student : User
    {
        public decimal GPA { get; set; }
        public int StudentCode {  get; set; }
        public DateTime EntryDate { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; } = new Department();

        public ICollection<Session> Sessions { get; set; } = new List<Session>();
    }
}
