using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID_130 { get; set; }
        public int CourseID_130 { get; set; }
        public int StudentID_130 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade_130 { get; set; }

        public Course Course_130 { get; set; }
        public Student Student_130 { get; set; }
    }
}