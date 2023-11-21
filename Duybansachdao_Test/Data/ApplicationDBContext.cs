using Microsoft.EntityFrameworkCore;
namespace Duybansachdao_Test.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }


    }
}
