using System.Collections.Generic;

namespace DevSkillSystem.FrameWork
{
    public interface ISubjectService
    {
         void AddSubject(Subject subject);
         void EditSubject(Subject subject);
         IList<Subject> GetAllSubjects();
         Subject GetSubject(int Id);
         void DeleteSubject(int Id);
    }
}