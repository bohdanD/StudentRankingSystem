using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRankingSystem.Entities
{
    public class Score
    {
        [Key]
        [Column(Order = 1)]
        public int ScoreId { get; set; }         
        public int CourseId { get; set; }        
        public int StudentId { get; set; }       
        public double FinalScore { get; set; }
        public int TermNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExamDate { get; set; }

    }
}
