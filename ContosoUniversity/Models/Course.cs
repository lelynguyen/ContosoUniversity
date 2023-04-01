using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID_130 { get; set; }
        public string Title_130 { get; set; }
        public int Credits_130 { get; set; }

        public ICollection<Enrollment> Enrollments_130 { get; set; }
    }
}