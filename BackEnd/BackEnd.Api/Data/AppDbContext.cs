using Microsoft.EntityFrameworkCore;

namespace BackEnd.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) :
            base(opt)
        {

        }
    }
}
