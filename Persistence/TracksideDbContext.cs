using Microsoft.EntityFrameworkCore;

namespace tracksideApp00.Persistence
{
    public class TracksideDbContext : DbContext
    {
        public TracksideDbContext(DbContextOptions<TracksideDbContext> options)
            : base(options)
        {
        }
    }
}
