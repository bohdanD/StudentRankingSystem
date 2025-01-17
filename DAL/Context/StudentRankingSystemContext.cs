﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRankingSystem.Entities;
using System.Data.Entity;
//Review BD: Please remove unnecessary usings.
namespace StudentRankingSystem.DAL.Context
{
    public class StudentRankingSystemContext : DbContext
    {
         
        public StudentRankingSystemContext() : base("StudentRankingSystem")
        {
          Database.SetInitializer(new StudentRankingSystemDbInitializer());
       
        }
     
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Score> Scores { get; set; }

    }
    }