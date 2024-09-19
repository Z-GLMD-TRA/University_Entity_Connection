using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Teacher : User
    {

        public int Level { get; set; }
        public float HIndex { get; set; }

        public TeacherType TeacherType { get; set; }

        public int DepartmentId {  get; set; }
        public Department Department { get; set; } = new Department();

        public ICollection<Session> Sessions { get; set; } = new List<Session>();


    }
    public enum TeacherType
    {
        FullTime,
        PartTime
    }
}
