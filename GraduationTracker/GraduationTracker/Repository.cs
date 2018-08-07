using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public class Repository
    {
        public static IStudent GetStudent(int id)
        {
            IStudent[] students = GetStudents();
            IStudent student = null;

            for (int i = 0; i < students.Length; i++)
            {
                if (id == students[i].Id)
                {
                    student = students[i];
                }
            }
            return student;
        }

        public static IDiploma GetDiploma(int id)
        {
            IDiploma[] diplomas = GetDiplomas();
            IDiploma diploma = null;

            for (int i = 0; i < diplomas.Length; i++)
            {
                if (id == diplomas[i].Id)
                {
                    diploma = diplomas[i];
                }
            }
            return diploma;

        }

        public static IRequirement GetRequirement(int id)
        {
            IRequirement[] requirements = GetRequirements();
            return requirements.Where(x => x.Id == id).SingleOrDefault();
        }


        private static IDiploma[] GetDiplomas()
        {
            return new[]
            {
                new Diploma
                {
                    Id = 1,
                    Credits = 4,
                    Requirements = new []{ GetRequirement(100), GetRequirement(102), GetRequirement(103), GetRequirement(104) }
                }
            };
        }

        public static IRequirement[] GetRequirements()
        {
            return new[]
            {
                    new Requirement{Id = 100, Name = "Math", MinimumMark=50, Courses = new []{GetCourse(1)}, Credits=1 },
                    new Requirement{Id = 102, Name = "Science", MinimumMark=50, Courses = new []{GetCourse(2)}, Credits=1 },
                    new Requirement{Id = 103, Name = "Literature", MinimumMark=50, Courses = new []{GetCourse(3)}, Credits=1},
                    new Requirement{Id = 104, Name = "Physichal Education", MinimumMark=50, Courses = new []{GetCourse(4)}, Credits=1 }
                };
        }
        private static IStudent[] GetStudents()
        {
            return new[]
            {
               new Student
               {
                   Id = 1,
                   Courses = new []
                {
                    GetCourse(1,95),
                    GetCourse(2,95),
                    GetCourse(3,95),
                    GetCourse(4,95)
                }
               },
               new Student
               {
                   Id = 2,
                   Courses = new []
                   {
                        GetCourse(1,80),
                        GetCourse(2,80),
                        GetCourse(3,80),
                        GetCourse(4,80)
                   }
               },
            new Student
            {
                Id = 3,
                Courses = new []
                {
                    GetCourse(1,50),
                    GetCourse(2,50),
                    GetCourse(3,50),
                    GetCourse(4,50)
                }
            },
            new Student
            {
                Id = 4,
                Courses = new []
                {
                    GetCourse(1,40),
                    GetCourse(2,40),
                    GetCourse(3,40),
                    GetCourse(4,40)
                }
            }

            };
        }
        private static ICourse[] GetCourses()
        {
            return new[]
                {
                    new Course{Id = 1, Name = "Math" },
                    new Course{Id = 2, Name = "Science" },
                    new Course{Id = 3, Name = "Literature" },
                    new Course{Id = 4, Name = "Physichal Education" }
                };
        }
        protected static ICourse GetCourse(int id, int marks)
        {
            ICourse[] courses = GetCourses();
            ICourse course = GetCourse(id);
            course.Mark = marks;
            return course;
        }
        protected static ICourse GetCourse(int id)
        {
            ICourse[] courses = GetCourses();
            return courses.Where(x => x.Id == id).SingleOrDefault();
        }
    }


}
