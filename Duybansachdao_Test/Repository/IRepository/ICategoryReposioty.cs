using Duybansachdao_Test.Models;
using Duybansachdao_Test.Models;
using Duybansachdao_Test.Repository.IRepository;

namespace Duybansachdao_Test.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}