using DevskillSystem.data;
using DevSkillSystem.FrameWork.Entities;

namespace DevSkillSystem.FrameWork.Repositories
{
    public class LeaveApplicationRepository:Repository<LeaveApplication,int,FrameWorkContext>, ILeaveApplicationRepository
    {
        public LeaveApplicationRepository(FrameWorkContext context) : base(context)
        {
        }
    }
}