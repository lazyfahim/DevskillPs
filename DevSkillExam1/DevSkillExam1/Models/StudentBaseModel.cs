using Autofac;
using Devskill.Framework;

namespace DevSkillExam1.Models
{
    public class StudentBaseModel
    {
        protected readonly IStudentService _studentService;
        public StudentBaseModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public StudentBaseModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<IStudentService>();
        }

        public void Dispose()
        {
            _studentService.Dispose();
        }
    }
}