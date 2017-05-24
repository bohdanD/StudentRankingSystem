using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Review BD: Please remove unnecessary usings in this and other classes.

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
