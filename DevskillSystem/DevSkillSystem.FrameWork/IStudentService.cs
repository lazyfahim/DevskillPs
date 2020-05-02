using System;
using System.Collections.Generic;

namespace DevSkillSystem.FrameWork
{
    public interface IStudentService:IDisposable
    {
        void CreateStudent(Student student);
        Student GetStudent(int Id);
        IList<Student> GetAllStudent();
        void EditStudent(Student student);
        void MarkGrade(int studentId, int subjectId,double gradevalue);
        void DeleteStudent(int Id);
    }
}