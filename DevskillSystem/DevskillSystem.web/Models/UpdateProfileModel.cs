using DevSkillSystem.FrameWork.Entities;
using DevSkillSystem.FrameWork.Services;
using DevskillSystem.web.hubs;
using Microsoft.AspNetCore.SignalR;

namespace DevskillSystem.web.Models
{
    public class UpdateProfileModel
    {
        private IEmployeeService _employeeService;
        private readonly IHubContext<NotificationHub> _notificationHub;

        public UpdateProfileModel(IEmployeeService employeeService, 
            IHubContext<NotificationHub> notificationHub)
        {
            _employeeService = employeeService;
            _notificationHub = notificationHub;
        }

        public void UpdateEmployee(Employee employee)
        {
            
        }
    }
}