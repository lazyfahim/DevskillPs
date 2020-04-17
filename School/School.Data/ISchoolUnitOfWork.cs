namespace School.Data
{
    public interface ISchoolUnitOfWork
    {
        IStudentRepository StudentRepository { get; set; }
        ICourseRepository CourseRepository { get; set; }
        void Dispose();
        void Save();
    }
}