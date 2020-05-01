using Devskill.Data;
using Microsoft.EntityFrameworkCore;

namespace Devskill.Framework
{
    public class StudentUnitOfWork:UnitOfWork, IStudentUnitOfWork
    {
        public IStudentRepository StudentRepository { get; set; }
        public ISubjectRepository SubjectRepository { get; set; }
        public StudentUnitOfWork(FrameworkContext context,IStudentRepository studentRepository,
            ISubjectRepository subjectRepository) : base(context)
        {
            StudentRepository = studentRepository;
            SubjectRepository = subjectRepository;
        }
    }
}