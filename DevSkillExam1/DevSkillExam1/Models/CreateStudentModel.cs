using Autofac;
using Devskill.Framework;

namespace DevSkillExam1.Models
{
    public class CreateStudentModel : StudentBaseModel
    {
        public CreateStudentModel(IStudentService studentService)
            :base(studentService)
        {
            
        }

        public CreateStudentModel()
            : base()
        {
            
        }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public void Create()
        {
            var student = new Student()
            {
                Name = this.Name,
                UserName = this.UserName,
                Email = this.Email
            };
            _studentService.AddStudent(student);
        }
    }
}