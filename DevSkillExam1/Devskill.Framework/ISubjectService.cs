using System.Collections.Generic;

namespace Devskill.Framework
{
    public interface ISubjectService
    {
        void AddSubject(Subject subject);
        void EditSubject(Subject subject);
        IList<Subject> GetAllSubjects();
        Subject GetSubject(int Id);
        void Delete(int Id);
        void Dispose();
    }
}