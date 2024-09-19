using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Session
    {
        public int SessionId { get; set; }
        public DateTime SessionTime { get; set; }
        public int SessionNumber { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; } = new Teacher();
        public int CourseId { get; set; }
        public Course Course { get; set; } = new Course();


    }
}
