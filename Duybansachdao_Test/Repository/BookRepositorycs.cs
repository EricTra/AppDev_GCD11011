using Duybansachdao_Test.Data;
using Duybansachdao_Test.Models;
using Duybansachdao_Test.Repository.IRepository;
using Duybansachdao_Test.Data;
using Duybansachdao_Test.Models;
using Duybansachdao_Test.Repository.IRepository;
using Duybansachdao_Test.Repository;
using BookShopWeb.Repository;

namespace Duybansachdao_Test.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public BookRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Update(Book book)
        {
            _dbContext.Update(book);
        }
    }
}