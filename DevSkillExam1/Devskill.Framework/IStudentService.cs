using System.Collections.Generic;

namespace Devskill.Framework
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        void EditStudent(Student student);
        Student GetStudent(int Id);
        IList<Student> GetStudents();
        void Dispose();
        void AddGradeToStudent(int studentId,int subjectId,double grade);
    }
}