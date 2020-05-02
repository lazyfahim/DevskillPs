using DevskillSystem.data;

namespace DevSkillSystem.FrameWork
{
    public class Grade:IEntity<int>
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public double GradeValue { get; set; }
        public int Id { get; set; }
    }
}