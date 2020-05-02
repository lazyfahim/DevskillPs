namespace DevskillSystem.data
{
    public interface IUnitOfWork
    {
        public void Dispose();
        public void Save();
    }
}