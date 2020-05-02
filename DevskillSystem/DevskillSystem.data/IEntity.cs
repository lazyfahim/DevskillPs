namespace DevskillSystem.data
{
    public interface IEntity<T>
    {
        public T Id { get; set; }
    }
}