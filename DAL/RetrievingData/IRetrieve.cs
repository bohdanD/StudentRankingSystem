using StudentRankingSystem.DAL.Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRankingSystem.DAL.RetrievingData
{
    interface IRetrieve
    {
        ICollection GetAverageScores();
        ICollection GetStudentsData();
    }
}
