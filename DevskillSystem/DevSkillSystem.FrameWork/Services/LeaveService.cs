using System;
using System.Collections.Generic;
using DevSkillSystem.FrameWork.Entities;

namespace DevSkillSystem.FrameWork.Services
{
    public class LeaveService:IDisposable, ILeaveService
    {
        private readonly INotificationUnitofWork _unitofWork;

        public LeaveService(INotificationUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public ICollection<LeaveApplication> GetAllLeaveApplication()
        {
            return new List<LeaveApplication>();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool GetLeave(LeaveApplication leaveApplication)
        {
            _unitofWork.LeaveApplicationRepository.Add(leaveApplication);
            return true;
        }

        public bool CancelLeave(int id)
        {
            return true;
        }

        public bool EditLeave(LeaveApplication leaveApplication)
        {
            return true;
        }

        public bool RejectLeave(int id)
        {
            return true;
        }

        private void AddNotificationtoQueue(LeaveApplication leaveApplication)
        {
        }
    }
}