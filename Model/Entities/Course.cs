using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; } = string.Empty;

        public ICollection<Session> Sessions { get; set; } = new List<Session>();
    }
}
