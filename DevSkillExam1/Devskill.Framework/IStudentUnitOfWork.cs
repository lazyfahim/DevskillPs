namespace Devskill.Framework
{
    public interface IStudentUnitOfWork
    {
        void Dispose();
        void Save();
    }
}