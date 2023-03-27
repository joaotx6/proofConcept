using Microsoft.EntityFrameworkCore;
using profConceptDB.DBEntities;



namespace profConceptDB.Context
{

    public class proofConceptContext : DbContext
    {
        public proofConceptContext(DbContextOptions<proofConceptContext> options) : base(options)
        {
            
        }
        public DbSet<Wand> wands { get; set; }
    }
}
