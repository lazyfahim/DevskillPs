using DevskillSystem.data;

namespace DevSkillSystem.FrameWork
{
    public class StudentRepository: Repository<Student,int,FrameWorkContext>, IStudentRepository
    {
        public StudentRepository(FrameWorkContext context) : base(context)
        {
        }
    }
}