using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options) : base(options) 
        {

        }

        //create a tables in db if it does not exist
        public DbSet<Region> Regions { get;set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

        internal Task FindAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
