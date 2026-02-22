using crud.Models;
using Microsoft.EntityFrameworkCore;

namespace crud.Data
{
    public class AddDbContext(DbContextOptions<AddDbContext> options) : DbContext(options)
    {
        public DbSet<Character> Characters => Set<Character>();
    }
}
