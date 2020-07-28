namespace A.C.E.S.Models
{
    /// <summary>
    /// This class links an assignment to a particular student
    /// </summary>
    public class StudentAssignment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int AssignmentId { get; set; }
        public string Watermark { get; set; }
        public string RepositoryUrl { get; set; }
    }
}
