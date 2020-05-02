using System.ComponentModel.DataAnnotations;
using DevSkillSystem.FrameWork;

namespace DevskillSystem.web.Models.StudentModels
{
    public class StudentCreateModel : StudentBaseModel
    {
        public StudentCreateModel() :base(){}

        public StudentCreateModel(IStudentService studentService) : base(studentService){}
        [Required]
        public string Name{get;set;}
        [Required]
        public string Email{get;set;}
        [Required]
        public string UserName{get;set;}
        public void CreateStudent()
        {
            var student =  new Student()
            {
                Name = this.Name,
                Email = this.Email,
                UserName = this.UserName
            };
            this._studentService.CreateStudent(student);
        }
    }
}