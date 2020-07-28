namespace A.C.E.S.Models
{
    /// <summary>
    /// This class links the student to a course
    /// </summary>
    public class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        /// <summary>
        /// If inactive, enrollment belongs to a past semester
        /// </summary>
        public bool Active { get; set; }
    }
}
