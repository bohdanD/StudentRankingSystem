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
            InitializeUsersTable(context);
            InitializeCoursesTable(context);
            InitializeTeachersTable(context);
            InitializeGroupsTable(context);
            InitializeStudentsTable(context);          

            context.SaveChanges();
            base.Seed(context);
        }

        #region InitializeTables
        private void InitializeUsersTable(StudentRankingSystemContext context)
        {
            var user = new User()
            {
                Login = "admin",
                Password = Other.Hashing.Encryptor.GetMD5Hash("123456"),
            };

            context.Users.Add(user);
        }

        private void InitializeCoursesTable(StudentRankingSystemContext context)
        {
            var course1 = new Course()
            {
                Name = "Object-oriented programming",
                TeacherId = 1
            };
            var course2 = new Course()
            {
                Name = "Algorithms and data structs",
                TeacherId = 1
            };
            var course3 = new Course()
            {
                Name = "Responsive Website Development and Design",
                TeacherId = 2
            };
            var course4 = new Course()
            {
                Name = "3D-modelling",
                TeacherId = 3
            };
            var course5 = new Course()
            {
                Name = "Stochastic modelling",
                TeacherId = 3
            };

            context.Courses.Add(course1);
            context.Courses.Add(course2);
            context.Courses.Add(course3);
            context.Courses.Add(course4);
            context.Courses.Add(course5);

        }
        private void InitializeTeachersTable(StudentRankingSystemContext context)
        {

            var teacher1 = new Teacher()
            {
                Name = "Ivan",
                Surname = "Tereschenko"
            };

            var teacher2 = new Teacher()
            {
                Name = "Ihor",
                Surname = "Dorosh"

            };

            var teacher3 = new Teacher()
            {
                Name = "Olexandr",
                Surname = "Pyhluk"
            };

            context.Teachers.Add(teacher1);
            context.Teachers.Add(teacher2);
            context.Teachers.Add(teacher3);
        }
        private void InitializeGroupsTable(StudentRankingSystemContext context)
        {
            var group1 = new Group()
            {
                Name = "FEI-51m",
                CourseId = 1
            };

            var group2 = new Group()
            {
                Name = "FEM-51",
                CourseId = 2
            };

            var group3 = new Group()
            {
                Name = "FEI-52",
                CourseId = 3
            };
            context.Groups.Add(group1);
            context.Groups.Add(group2);
            context.Groups.Add(group3);
        }
        private void InitializeStudentsTable(StudentRankingSystemContext context)
        {
            var student1 = new Student()
            {
                Name = "Bohdan",
                Surname = "Chornyi",
                GroupId = 3
            };
            var student2 = new Student()
            {
                Name = "Mykola",
                Surname = "Yaciv",
                GroupId = 2
            };
            var student3 = new Student()
            {
                Name = "Orest",
                Surname = "Mavyanyi",
                GroupId = 3
            };
            var student4 = new Student()
            {
                Name = "Viacheslav",
                Surname = "Holoduk",
                GroupId = 3
            };
            var student5 = new Student()
            {
                Name = "Ihor",
                Surname = "Zohnuk",
                GroupId = 3
            };
            var student6 = new Student()
            {
                Name = "Bohdan",
                Surname = "Malevych",
                GroupId = 1
            };
            var student7 = new Student()
            {
                Name = "Vira",
                Surname = "Taranko",
                GroupId = 3
            };
            var student8= new Student()
            {
                Name = "Nadia",
                Surname = "Vernydub",
                GroupId = 3
            };
            var student9 = new Student()
            {
                Name = "Yaroslava",
                Surname = "Cybulska",
                GroupId = 1
            };
            var student10 = new Student()
            {
                Name = "Lubov",
                Surname = "Karpova",
                GroupId = 2
            };
            var student11 = new Student()
            {
                Name = "Sofia",
                Surname = "Muzychuk",
                GroupId = 2
            };
            var student12 = new Student()
            {
                Name = "Lubov",
                Surname = "Karpova",
                GroupId = 3
            };
            var student13 = new Student()
            {
                Name = "Valeria",
                Surname = "Hontareva",
                GroupId = 2
            };
            var student14 = new Student()
            {
                Name = "Arsenii",
                Surname = "Yacenuk",
                GroupId = 2
            };
            var student15 = new Student()
            {
                Name = "Victor",
                Surname = "Yuschenko",
                GroupId = 1
            };
            var student16 = new Student()
            {
                Name = "Victor",
                Surname = "Yanikovych",
                GroupId = 1
            };
            var student17 = new Student()
            {
                Name = "Hannah",
                Surname = "Herman",
                GroupId = 2
            };
            var student18 = new Student()
            {
                Name = "Angela",
                Surname = "Merkel",
                GroupId = 1
            };
            var student19 = new Student()
            {
                Name = "Hannah",
                Surname = "Montana",
                GroupId = 1
            };
            var student20 = new Student()
            {
                Name = "Tony",
                Surname = "Montana",
                GroupId = 2
            };
            var student21 = new Student()
            {
                Name = "George",
                Surname = "Harrison",
                GroupId = 2
            };
            context.Students.Add(student1);
            context.Students.Add(student2);
            context.Students.Add(student3);
        }

        #endregion
    }
}
