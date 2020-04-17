using Microsoft.EntityFrameworkCore;
using School.Contracts;
using School.Models;

namespace School.Data
{
    public class StudentRepository: Repository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}