using Microsoft.EntityFrameworkCore;
using UdemyApp.Entities;

namespace UdemyApp.Data
{
    public class UserData(DbContextOptions options) : DbContext(options)
    {
        public DbSet<AppUsers> Users { get; set; }
    }
}
