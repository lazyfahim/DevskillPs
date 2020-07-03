using DevskillSystem.data;
using Microsoft.EntityFrameworkCore;

namespace DevSkillSystem.FrameWork
{
    public class StudentUnitOfWork:UnitOfWork, IStudentUnitOfWork    
    {
        public IStudentRepository StudentRepository { get; set; }
        public ISubjectRepository SubjectRepository { get; set; }
        public StudentUnitOfWork(FrameWorkContext dbContext,
            IStudentRepository studentRepository,
            ISubjectRepository subjectRepository) 
            : base(dbContext)
        {
            StudentRepository = studentRepository;
            SubjectRepository = subjectRepository;
        }
    }
}