namespace Duybansachdao_Test.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IBookRepository Book { get; }
        void Save();
    }
}
