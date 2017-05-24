using StudentRankingSystem.DAL.Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Review BD: Please remove unnecessary usings.
namespace StudentRankingSystem.DAL.RetrievingData
{
    //Review BD: Use explicit access modifiers.
    interface IRetrieve
    {
        ICollection GetAverageScores();
        ICollection GetStudentsData();
    }
}
