using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace School.Data
{
    public interface IRepository<T> where T : class
    {
        public void Add(T entity);
        public void Edit(T entityToUpdate);

        public IEnumerable<T> Get(
            out int total, out int totalDisplay,
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "", int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

        public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "", bool isTrackingOff = false);

        public T GetById(int id);
        public int GetCount(Expression<Func<T, bool>> filter = null);
        public void Remove(int id);
        public void Remove(T entityToDelete);
        public void Remove(Expression<Func<T, bool>> filter);
    }
}