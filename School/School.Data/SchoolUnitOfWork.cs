using School.Contracts;

namespace School.Data
{
    public class SchoolUnitOfWork:UnitOfWork<AppContext>, ISchoolUnitOfWork
    {
        public IStudentRepository StudentRepository { get; set; }
        public ICourseRepository CourseRepository { get; set; }
        public SchoolUnitOfWork(string connectionString, string migrationAssemblyName) : 
            base(connectionString, migrationAssemblyName)
        {
            StudentRepository = new StudentRepository(_dbContext);
        }
    }
}