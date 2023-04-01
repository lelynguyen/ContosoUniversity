using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstMidName_130="Carson",LastName_130="Alexander",EnrollmentDate_130=DateTime.Parse("2019-09-01")},
                new Student{FirstMidName_130="Meredith",LastName_130="Alonso",EnrollmentDate_130=DateTime.Parse("2017-09-01")},
                new Student{FirstMidName_130="Arturo",LastName_130="Anand",EnrollmentDate_130=DateTime.Parse("2018-09-01")},
                new Student{FirstMidName_130="Gytis",LastName_130="Barzdukas",EnrollmentDate_130=DateTime.Parse("2017-09-01")},
                new Student{FirstMidName_130="Yan",LastName_130="Li",EnrollmentDate_130=DateTime.Parse("2017-09-01")},
                new Student{FirstMidName_130="Peggy",LastName_130="Justice",EnrollmentDate_130=DateTime.Parse("2016-09-01")},
                new Student{FirstMidName_130="Laura",LastName_130="Norman",EnrollmentDate_130=DateTime.Parse("2018-09-01")},
                new Student{FirstMidName_130="Nino",LastName_130="Olivetto",EnrollmentDate_130=DateTime.Parse("2019-09-01")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID_130=1050,Title_130="Chemistry",Credits_130=3},
                new Course{CourseID_130=4022,Title_130="Microeconomics",Credits_130=3},
                new Course{CourseID_130=4041,Title_130="Macroeconomics",Credits_130=3},
                new Course{CourseID_130=1045,Title_130="Calculus",Credits_130=4},
                new Course{CourseID_130=3141,Title_130="Trigonometry",Credits_130=4},
                new Course{CourseID_130=2021,Title_130="Composition",Credits_130=3},
                new Course{CourseID_130=2042,Title_130="Literature",Credits_130=4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID_130=1,CourseID_130=1050,Grade_130=Grade.A},
                new Enrollment{StudentID_130=1,CourseID_130=4022,Grade_130=Grade.C},
                new Enrollment{StudentID_130=1,CourseID_130=4041,Grade_130=Grade.B},
                new Enrollment{StudentID_130=2,CourseID_130=1045,Grade_130=Grade.B},
                new Enrollment{StudentID_130=2,CourseID_130=3141,Grade_130=Grade.F},
                new Enrollment{StudentID_130=2,CourseID_130=2021,Grade_130=Grade.F},
                new Enrollment{StudentID_130=3,CourseID_130=1050},
                new Enrollment{StudentID_130=4,CourseID_130=1050},
                new Enrollment{StudentID_130=4,CourseID_130=4022,Grade_130=Grade.F},
                new Enrollment{StudentID_130=5,CourseID_130=4041,Grade_130=Grade.C},
                new Enrollment{StudentID_130=6,CourseID_130=1045},
                new Enrollment{StudentID_130=7,CourseID_130=3141,Grade_130=Grade.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}