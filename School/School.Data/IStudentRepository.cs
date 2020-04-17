using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using School.Models;

namespace School.Data
{
    public interface IStudentRepository
    {
        void Add(Student entity);
        void Edit(Student entityToUpdate);

        IEnumerable<Student> Get(
            out int total, out int totalDisplay,
            Expression<Func<Student, bool>> filter = null,
            Func<IQueryable<Student>, IOrderedQueryable<Student>> orderBy = null,
            string includeProperties = "", int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

        IEnumerable<Student> Get(Expression<Func<Student, bool>> filter = null,
            Func<IQueryable<Student>, IOrderedQueryable<Student>> orderBy = null,
            string includeProperties = "", bool isTrackingOff = false);

        Student GetById(int id);
        int GetCount(Expression<Func<Student, bool>> filter = null);
        void Remove(int id);
        void Remove(Student entityToDelete);
        void Remove(Expression<Func<Student, bool>> filter);
    }
}