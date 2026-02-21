using Microsoft.EntityFrameworkCore;

namespace crud.Data
{
    public class AddDbContext : DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options)
        {
        }
            public DbSet<Models.Character> Characters { get; set; }
    }
}
