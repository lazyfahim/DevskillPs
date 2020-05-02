using DevskillSystem.data;

namespace DevSkillSystem.FrameWork
{
    public class SubjectRepository:Repository<Subject,int,FrameWorkContext>, ISubjectRepository
    {
        public SubjectRepository(FrameWorkContext context) : base(context)
        {
        }
    }
}