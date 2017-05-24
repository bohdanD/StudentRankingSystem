using StudentRankingSystem.Entities;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Review BD: Please remove unnecessary usings.


namespace StudentRankingSystem.DAL.Context
{
    public class StudentRankingSystemDbInitializer : DropCreateDatabaseAlways<StudentRankingSystemContext>
    {
        protected override void Seed(StudentRankingSystemContext context)
        {
            InitializeUsersTable(context);
            InitializeCoursesTable(context);
            context.SaveChanges();
            InitializeTeachersTable(context);
            InitializeGroupsTable(context);
            InitializeStudentsTable(context);
         

            context.SaveChanges();
            InitializeScoresTable(context);
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

        //Review BD: There are creation of many instances of the one class in the following methods.
        //It would be better to use List and loop to add data to the context.
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
                Name = "Bill",
                Surname = "Gates"
            };

            var teacher2 = new Teacher()
            {
                Name = "Steve",
                Surname = "Voznyak"

            };

            var teacher3 = new Teacher()
            {
                Name = "Mark",
                Surname = "Zuckerberg"
            };

            context.Teachers.Add(teacher1);
            context.Teachers.Add(teacher2);
            context.Teachers.Add(teacher3);
        }
        private void InitializeGroupsTable(StudentRankingSystemContext context)
        {
            var FEI51mCourses = context.Courses.Where(c => c.CourseId == 5 || c.CourseId == 3).ToList<Course>();
            var FEM51Courses = context.Courses.Where(c => c.CourseId == 1 || c.CourseId == 2 || c.CourseId == 4).ToList<Course>();
            var FEI52Courses = context.Courses.Where(c => c.CourseId == 5 || c.CourseId == 1 || c.CourseId == 2).ToList<Course>();

            var group1 = new Group()
            {
                Name = "FEI-51m",
                Courses = new HashSet<Course>(FEI51mCourses)     
            };

            var group2 = new Group()
            {
                Name = "FEM-51",
                Courses = new HashSet<Course>(FEM51Courses)          
            };

            var group3 = new Group()
            {
                Name = "FEI-52",
                Courses = new HashSet<Course>(FEI52Courses)        
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
            var student8 = new Student()
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
                Surname = "Yanukovych",
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
            context.Students.Add(student4);
            context.Students.Add(student5);
            context.Students.Add(student6);
            context.Students.Add(student7);
            context.Students.Add(student8);
            context.Students.Add(student9);
            context.Students.Add(student10);

            context.Students.Add(student11);
            context.Students.Add(student12);
            context.Students.Add(student13);
            context.Students.Add(student14);
            context.Students.Add(student15);
            context.Students.Add(student16);
            context.Students.Add(student17);
            context.Students.Add(student18);
            context.Students.Add(student19);
            context.Students.Add(student20);
            context.Students.Add(student21);
        }
        private void InitializeScoresTable(StudentRankingSystemContext context)
        {
            Random rand = new Random();

            //var scores = from st in context.Students
            //             from grp in context.Groups
            //             where grp.GroupId == st.GroupId
            //             from crs in grp.Courses                        
            //             select new
            //             {
            //                 CourseId = crs.CourseId,
            //                 StudentId = st.StudentId,
            //                 ExamDate = new DateTime(2017, 5, 15),
            //                 TermNumber = 2,
            //                 FinalScore = rand.Next(2, 6)
            //             };

            //foreach (var s in scores)
            //{
            //    context.Scores.Add(new Score
            //    {
            //        CourseId = s.CourseId,
            //        StudentId = s.StudentId,
            //        ExamDate = s.ExamDate,
            //        TermNumber = s.TermNumber,
            //        FinalScore = s.FinalScore
            //    });
            //}

            //context.Scores.AddRange(scores);


            foreach (var student in context.Students)
            {
                foreach (var grp in context.Groups)
                {
                    if (student.GroupId == grp.GroupId)
                    {
                        foreach (var crs in grp.Courses)
                        {

                            context.Scores.Add(new Score
                            {
                                CourseId = crs.CourseId,
                                StudentId = student.StudentId,
                                ExamDate = new DateTime(2017, 5, 15),
                                TermNumber = 2,
                                FinalScore = rand.Next(2, 6)
                            });
                        }
                    }

                }
            }


        }


        #endregion
    }
}
