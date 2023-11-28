using Duybansachdao_Test.Data;
using Duybansachdao_Test.Repository.IRepository;
namespace Duybansachdao_Test.Repository
{
    public class UnitOfWorks : IUnitOfWork
    {
        private readonly ApplicationDBContext _dbContext;
        public ICategoryRepository CategoryRepository => throw new NotImplementedException();

        public IBookRepository Book => throw new NotImplementedException();

        public ICategoryRepository Category => throw new NotImplementedException();

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
