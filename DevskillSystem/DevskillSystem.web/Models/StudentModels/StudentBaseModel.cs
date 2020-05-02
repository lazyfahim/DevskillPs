using System;
using Autofac;
using DevSkillSystem.FrameWork;

namespace DevskillSystem.web.Models.StudentModels
{
    public class StudentBaseModel:IDisposable
    {
        internal IStudentService _studentService;
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