using Microsoft.EntityFrameworkCore;

namespace OOProjectBasedLeaning
{
    public static class DbContextFactory
    {
        private static readonly string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=OOProjectBasedLeaning;Trusted_Connection=True;";

        public static AppDbContext Create()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            return new AppDbContext(options);
        }
    }
}
