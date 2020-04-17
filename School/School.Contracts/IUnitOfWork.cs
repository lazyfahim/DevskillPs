using System;
using Microsoft.EntityFrameworkCore;

namespace School.Data
{
    public interface IUnitOfWork<T> : IDisposable where T : DbContext
    {
        public void Dispose();
        public void Save();
    }
}