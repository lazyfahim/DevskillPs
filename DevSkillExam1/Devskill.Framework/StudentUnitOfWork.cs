using Devskill.Data;
using Microsoft.EntityFrameworkCore;

namespace Devskill.Framework
{
    public class StudentUnitOfWork:UnitOfWork, IStudentUnitOfWork
    {
        public StudentUnitOfWork(DbContext dbContext) : base(dbContext)
        {
        }
    }
}