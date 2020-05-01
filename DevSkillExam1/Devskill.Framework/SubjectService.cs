using System;
using System.Collections.Generic;

namespace Devskill.Framework
{
    public class SubjectService:IDisposable, ISubjectService
    {
        private IStudentUnitOfWork _studentUnitOfWork;

        public SubjectService(IStudentUnitOfWork studentUnitOfWork)
        {
            _studentUnitOfWork = studentUnitOfWork;
        }

        public void AddSubject(Subject subject)
        {
            _studentUnitOfWork.SubjectRepository.Add(subject);
            _studentUnitOfWork.Save();
        }

        public void EditSubject(Subject subject)
        {
            var subjecttoedit = _studentUnitOfWork.SubjectRepository.GetById(subject.Id);
            subjecttoedit = subject;
            _studentUnitOfWork.Save();
        }
        public IList<Subject> GetAllSubjects()
        {
            return _studentUnitOfWork.SubjectRepository.GetAll();
        }

        public Subject GetSubject(int Id)
        {
            return _studentUnitOfWork.SubjectRepository.GetById(Id);
        }

        public void Delete(int Id)
        {
            _studentUnitOfWork.SubjectRepository.Remove(Id);
            _studentUnitOfWork.Save();
        }
        public void Dispose()
        {
            _studentUnitOfWork.Dispose();
        }
    }
}