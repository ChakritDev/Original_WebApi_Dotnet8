using Microsoft.EntityFrameworkCore;

namespace DemoWebAPI.Datas
{
    public class AppDbContext2 : DbContext
    {
        public AppDbContext2(DbContextOptions<AppDbContext2> options)
            : base(options)
        {

        }

        // public DbSet<UserModel> DbUser { get; set; } = null!;


    }
}
