using DevskillSystem.data;
using DevSkillSystem.FrameWork.Entities;

namespace DevSkillSystem.FrameWork.Repositories
{
    public class EmployeeRepository:Repository<Employee,int,FrameWorkContext>, IEmployeeRepository
    {
        public EmployeeRepository(FrameWorkContext context) : base(context)
        {
        }
    }
}