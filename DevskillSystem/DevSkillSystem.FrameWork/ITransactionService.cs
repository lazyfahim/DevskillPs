using System.Collections.Generic;

namespace DevSkillSystem.FrameWork
{
    public interface ITransactionService
    {
        void AddTransaction(Transaction transaction);
        void Edit(Transaction transaction);
        void Delete(int Id);
        Transaction GetTransaction(int Id);
        IList<Transaction> GetAll();
        void Dispose();
    }
}