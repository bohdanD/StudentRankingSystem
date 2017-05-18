using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRankingSystem.Entities
{
    public class Score
    {
        public int ScoreId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public double FinalScore { get; set; }

        public DateTime ExamDate { get; set; }

    }
}
