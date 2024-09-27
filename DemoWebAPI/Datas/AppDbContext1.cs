using Microsoft.EntityFrameworkCore;

namespace DemoWebAPI.Datas
{
    public class AppDbContext1 : DbContext
    {
        public AppDbContext1(DbContextOptions<AppDbContext1> options)
            : base(options)
        {

        }

        // public DbSet<UserModel> DbUser { get; set; } = null!;


    }
}
