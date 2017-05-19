 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRankingSystem.Entities
{
    public class Group
    {
        public Group()
        {
            Courses = new HashSet<Course>();
        }
        public int GroupId { get; set; }
        public string Name { get; set; }
        //public int CourseRequiredId { get; set; }
        //public int? CourseAdditional1Id { get; set; }
        //public int? CourseAdditional2Id { get; set; }

        //public virtual Course CourseRequired { get; set; }
        //public virtual Course CourseAdditional1 { get; set; }
        //public virtual Course CourseAdditional2 { get; set; }

        public virtual   ICollection<Course> Courses { get; set; }

    }
}
