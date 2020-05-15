using DevskillSystem.data;
using Microsoft.EntityFrameworkCore;

namespace DevSkillSystem.FrameWork
{
    public class TransactionUnitOfWork:UnitOfWork, ITransactionUnitOfWork
    {
        public ITransactionRepository TransactionRepository { get; set; }
        public TransactionUnitOfWork(FrameWorkContext dbContext,
            ITransactionRepository transactionRepository) 
            : base(dbContext)
        {
            TransactionRepository = transactionRepository;
        }
    }
}