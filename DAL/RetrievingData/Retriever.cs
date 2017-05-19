using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRankingSystem.DAL.Context;

namespace StudentRankingSystem.DAL.RetrievingData
{
    public class Retriever : IRetrieve
    {
        public ICollection GetAverageScores()
        {
            using (StudentRankingSystemContext context = new StudentRankingSystemContext())
            {

                var studentsScores = from student in context.Students
                          join score in context.Scores
                          on student.StudentId equals score.StudentId
                          select new
                          {
                              StudentID = student.StudentId,
                              Score = score.FinalScore
                          };

                var averageScores = studentsScores.GroupBy(s => s.StudentID).Select
                                                                                (g => new
                                                                                   {
                                                                                      AverageScore = g.Average(s => s.Score),
                                                                                      StudentID = g.Key
                                                                                   }).ToList();
                return averageScores;
            }


        }

        public ICollection GetStudentsData()
        {
            using (StudentRankingSystemContext context = new StudentRankingSystemContext())
            {
                var studentsData = context.Students.Select(s => new { StudentName = s.Name, StudentSurname = s.Surname  });
                return studentsData.ToList();
            }
           
       }

       

    }
}
