using System;
using Microsoft.EntityFrameworkCore;

namespace School.Contracts
{
    public interface IUnitOfWork<T> : IDisposable where T : DbContext
    {
        public void Dispose();
        public void Save();
    }
}