using DevSkillSystem.FrameWork.Entities;
using DevSkillSystem.FrameWork.Services;
using DevskillSystem.web.hubs;
using Microsoft.AspNetCore.SignalR;

namespace DevskillSystem.web.Models.LeaveApplicationModels
{
    public class ApplyorModifyLeaveApplication:LeaveApplicationModelBase
    {
        public LeaveApplication LeaveApplication { get; private set; }
        private INotificationService _notificationService;
        private readonly IHubContext<NotificationHub> _hubContext;
        public ApplyorModifyLeaveApplication(ILeaveService leaveService,
            INotificationService notificationService,
            IHubContext<NotificationHub> hubContext)
        :base(leaveService)
        {
            this._hubContext = hubContext;
            this._notificationService = notificationService;
        }

        public ApplyorModifyLeaveApplication()
        :base()
        {
            
        }

        public void ApplyLeave(LeaveApplication application)
        {
        }

        public void ApproveLeave(int id)
        {
            
        }

        public void ModifyLeave(LeaveApplication leaveApplication)
        {
            
        }
        
    }
}