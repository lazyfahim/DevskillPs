using System.Collections.Generic;
using DevSkillSystem.FrameWork;

namespace DevskillSystem.web.Models.StudentModels
{
    public class StudentModel: StudentBaseModel
    {
        public StudentModel() :base(){}

        public StudentModel(IStudentService studentService) : base(studentService){}

        public IList<Student> GetAll()
        {
            return _studentService.GetAllStudent();
        }

        public Student Get(int Id)
        {
            return _studentService.GetStudent(Id);
        }
    }
}