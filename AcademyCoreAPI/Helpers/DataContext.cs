using AcademyCoreAPI.DataModels;
using Microsoft.EntityFrameworkCore;

namespace AcademyCoreAPI.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }
    }
}