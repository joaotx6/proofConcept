

namespace proofConceptDB.Context
{

    using Microsoft.EntityFrameworkCore;
    using proofConceptDB.DBEntities;

    public class proofConceptContext : DbContext
    {
        public proofConceptContext(DbContextOptions<proofConceptContext> options) : base(options)
        {
            
        }
        public DbSet<Wand> wands { get; set; }
    }
}
