using DevskillSystem.data;

namespace DevSkillSystem.FrameWork
{
    public class TransactionRepository:Repository<Transaction,int,FrameWorkContext>, ITransactionRepository
    {
        public TransactionRepository(FrameWorkContext context) : base(context)
        {
        }
    }
}