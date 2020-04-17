using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using School.Models;

namespace School.Data
{
    public interface ICourseRepository
    {
        void Add(Course entity);
        void Edit(Course entityToUpdate);

        IEnumerable<Course> Get(
            out int total, out int totalDisplay,
            Expression<Func<Course, bool>> filter = null,
            Func<IQueryable<Course>, IOrderedQueryable<Course>> orderBy = null,
            string includeProperties = "", int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

        IEnumerable<Course> Get(Expression<Func<Course, bool>> filter = null,
            Func<IQueryable<Course>, IOrderedQueryable<Course>> orderBy = null,
            string includeProperties = "", bool isTrackingOff = false);

        Course GetById(int id);
        int GetCount(Expression<Func<Course, bool>> filter = null);
        void Remove(int id);
        void Remove(Course entityToDelete);
        void Remove(Expression<Func<Course, bool>> filter);
    }
}