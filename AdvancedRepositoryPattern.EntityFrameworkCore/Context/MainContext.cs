using Microsoft.EntityFrameworkCore;

namespace AdvancedRepositoryPattern.EntityFrameworkCore.Context
{
    public class MainContext : DbContext
    {
        private readonly string _connectionString;
        public MainContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(_connectionString);
    }
}
