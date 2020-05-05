using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace DevSkillSystem.FrameWork
{
    public interface IStudentRepository
    {
        void Add(Student entity);
        void Remove(Int32 id);
        void Remove(Student entityToDelete);
        void Remove(Expression<Func<Student, bool>> filter);
        void Edit(Student entityToUpdate);
        int GetCount(Expression<Func<Student, bool>> filter = null);
        IList<Student> Get(Expression<Func<Student, bool>> filter);
        IList<Student> GetAll();
        Student GetById(Int32 id);

        (IList<Student> data, int total, int totalDisplay) Get(
            Expression<Func<Student, bool>> filter = null,
            Func<IQueryable<Student>, IOrderedQueryable<Student>> orderBy = null,
            Func<IQueryable<Student>, IIncludableQueryable<Student, object>> include = null, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

        (IList<Student> data, int total, int totalDisplay) GetDynamic(
            Expression<Func<Student, bool>> filter = null,
            string orderBy = null,
            Func<IQueryable<Student>, IIncludableQueryable<Student, object>> include = null, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

        IList<Student> Get(Expression<Func<Student, bool>> filter = null,
            Func<IQueryable<Student>, IOrderedQueryable<Student>> orderBy = null,
            Func<IQueryable<Student>, IIncludableQueryable<Student, object>> include = null, bool isTrackingOff = false);

        IList<Student> GetDynamic(Expression<Func<Student, bool>> filter = null,
            string orderBy = null,
            Func<IQueryable<Student>, IIncludableQueryable<Student, object>> include = null
            , bool isTrackingOff = false);
    }
}