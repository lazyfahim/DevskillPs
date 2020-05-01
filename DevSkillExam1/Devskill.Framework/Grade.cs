using Devskill.Data;

namespace Devskill.Framework
{
    public class Grade:IEntity<int>
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public double GradeValue { get; set; }
    }
}