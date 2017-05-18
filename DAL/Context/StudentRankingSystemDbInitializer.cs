using StudentRankingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRankingSystem.DAL.Context
{
   public  class StudentRankingSystemDbInitializer : DropCreateDatabaseIfModelChanges<StudentRankingSystemContext>
    {

        protected override void Seed(StudentRankingSystemContext context)
        {
            var user = new User()
            {
                 
                Login = "admin",              
                Password = "123456",
               
            };

            context.Users.Add(user);

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
