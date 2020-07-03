using System.Collections.Generic;
using DevSkillSystem.FrameWork.Entities;

namespace DevSkillSystem.FrameWork.Services
{
    public interface ILeaveService
    {
        ICollection<LeaveApplication> GetAllLeaveApplication();
        void Dispose();
        bool GetLeave(LeaveApplication leaveApplication);
        bool CancelLeave(int id);
        bool EditLeave(LeaveApplication leaveApplication);
        bool RejectLeave(int id);
    }
}