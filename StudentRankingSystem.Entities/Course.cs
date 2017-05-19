using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRankingSystem.Entities
{
    public class Course
    {
        public Course()
        {
            Groups = new HashSet<Group>();
        }
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }

        public virtual ICollection<Group> Groups { get; set; }

       
    }
}
