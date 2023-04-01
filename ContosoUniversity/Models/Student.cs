namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID_130 { get; set; }
        public string LastName_130 { get; set; }
        public string FirstMidName_130 { get; set; }
        public DateTime EnrollmentDate_130 { get; set; }

        public ICollection<Enrollment> Enrollments_130 { get; set; }
    }
}