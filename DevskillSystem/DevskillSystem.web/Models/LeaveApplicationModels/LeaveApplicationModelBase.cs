using System;
using DevSkillSystem.FrameWork.Services;

namespace DevskillSystem.web.Models.LeaveApplicationModels
{
    public class LeaveApplicationModelBase:IDisposable
    {
        internal ILeaveService _leaveService;

        public LeaveApplicationModelBase(ILeaveService leaveService)
        {
            _leaveService = leaveService;
        }

        public LeaveApplicationModelBase()
        {
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}