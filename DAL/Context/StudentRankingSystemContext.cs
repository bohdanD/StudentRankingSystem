using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRankingSystem.Entities;
using System.Data.Entity;

namespace StudentRankingSystem.DAL.Context
{
    public class StudentRankingSystemContext : DbContext
    {
        // Имя будущей базы данных можно указать через
        // вызов конструктора базового класса
        public StudentRankingSystemContext() : base("StudentRankingSystem")
        {
          Database.SetInitializer<StudentRankingSystemContext>(new StudentRankingSystemDbInitializer());
       
        }

        // Отражение таблиц базы данных на свойства с типом DbSet
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }


    }
    }