using Devskill.Data;

namespace Devskill.Framework
{
    public class SubjectRepository:Repository<Subject,int,FrameworkContext>, ISubjectRepository
    {
        public SubjectRepository(FrameworkContext context) : base(context)
        {
        }
    }
}