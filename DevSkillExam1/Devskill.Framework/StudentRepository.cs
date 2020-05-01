using Devskill.Data;

namespace Devskill.Framework
{
    public class StudentRepository:Repository<Student,int,FrameworkContext>, IStudentRepository
    {
        public StudentRepository(FrameworkContext context) : base(context)
        {
        }
    }
}