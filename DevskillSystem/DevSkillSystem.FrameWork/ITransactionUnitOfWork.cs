namespace DevSkillSystem.FrameWork
{
    public interface ITransactionUnitOfWork
    {
        ITransactionRepository TransactionRepository { get; set; }
        void Dispose();
        void Save();
    }
}