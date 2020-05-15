using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace DevSkillSystem.FrameWork
{
    public interface ITransactionRepository
    {
        void Add(Transaction entity);
        void Remove(Int32 id);
        void Remove(Transaction entityToDelete);
        void Remove(Expression<Func<Transaction, bool>> filter);
        void Edit(Transaction entityToUpdate);
        int GetCount(Expression<Func<Transaction, bool>> filter = null);
        IList<Transaction> Get(Expression<Func<Transaction, bool>> filter);
        IList<Transaction> GetAll();
        Transaction GetById(Int32 id);

        (IList<Transaction> data, int total, int totalDisplay) Get(
            Expression<Func<Transaction, bool>> filter = null,
            Func<IQueryable<Transaction>, IOrderedQueryable<Transaction>> orderBy = null,
            Func<IQueryable<Transaction>, IIncludableQueryable<Transaction, object>> include = null, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

        (IList<Transaction> data, int total, int totalDisplay) GetDynamic(
            Expression<Func<Transaction, bool>> filter = null,
            string orderBy = null,
            Func<IQueryable<Transaction>, IIncludableQueryable<Transaction, object>> include = null, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

        IList<Transaction> Get(Expression<Func<Transaction, bool>> filter = null,
            Func<IQueryable<Transaction>, IOrderedQueryable<Transaction>> orderBy = null,
            Func<IQueryable<Transaction>, IIncludableQueryable<Transaction, object>> include = null, bool isTrackingOff = false);

        IList<Transaction> GetDynamic(Expression<Func<Transaction, bool>> filter = null,
            string orderBy = null,
            Func<IQueryable<Transaction>, IIncludableQueryable<Transaction, object>> include = null
            , bool isTrackingOff = false);
    }
}