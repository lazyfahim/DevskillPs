namespace Devskill.Framework
{
    public interface IStudentUnitOfWork
    {
        IStudentRepository StudentRepository { get; set; }
        ISubjectRepository SubjectRepository { get; set; }
        void Dispose();
        void Save();
    }
}