using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proofConceptDAL.Interfaces;
using proofConceptDB.DBEntities;


namespace proofConceptDAL.Implementations
{
    public class wandRepository: IAWandRepository
    { 
        private readonly proofConceptDB.Context.proofConceptContext context;

        public wandRepository(proofConceptDB.Context.proofConceptContext proofConceptContext)
        {
            context = proofConceptContext;
        }
        public IQueryable<Wand> Wands => context.wands;
    }
}
