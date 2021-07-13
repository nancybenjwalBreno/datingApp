using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Data
{
    public class DataContext : DbContext // DbContext is the primary class that is responsible for interacting with the database
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public  DbSet<AppUser> Users{get; set; }
    }
}
