using System;
using Microsoft.EntityFrameworkCore;

namespace DevskillSystem.data
{
    public class UnitOfWork:IDisposable, IUnitOfWork
    {
        protected readonly DbContext _dbContext;
        public UnitOfWork(DbContext dbContext) => _dbContext = dbContext;
        public void Dispose() => _dbContext?.Dispose();
        public void Save() => _dbContext.SaveChanges();
    }
}