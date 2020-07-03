using DevSkillSystem.FrameWork.Entities;

namespace DevSkillSystem.FrameWork.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly INotificationUnitofWork _unitofWork;

        public EmployeeService(INotificationUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public void UpdateProfile(Employee employee)
        {
            _unitofWork.EmployeeRepository.Edit(employee);
        }

        private void AddNotificationtoQueue(Employee employee)
        {
            
        }
    }
}