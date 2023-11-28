using Duybansachdao_Test.Data;
using Duybansachdao_Test.Models;
using Duybansachdao_Test.Repository.IRepository;
using Duybansachdao_Test.Data;
using Duybansachdao_Test.Models;
using Duybansachdao_Test.Repository.IRepository;

namespace BookShopWeb.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public CategoryRepository(ApplicationDBContext dBContext) : base(dBContext)
        {
            _dbContext = dBContext;
        }

        public void Update(Category category)
        {
            _dbContext.Update(category);
        }
    }
}