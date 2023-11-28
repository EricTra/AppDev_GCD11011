using Duybansachdao_Test.Models;
using Duybansachdao_Test.Models;
using Duybansachdao_Test.Repository.IRepository;

namespace Duybansachdao_Test.Repository.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {
        void Update(Book book);
    }
}