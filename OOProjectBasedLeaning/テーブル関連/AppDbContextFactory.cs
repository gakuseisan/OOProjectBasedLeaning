using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace OOProjectBasedLeaning
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // LocalDB 接続文字列
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=OOProjectBasedLeaning;Trusted_Connection=True;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
