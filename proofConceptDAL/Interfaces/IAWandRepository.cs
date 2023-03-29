using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proofConceptDB.DBEntities;

namespace proofConceptDAL.Interfaces
{
    public class IAWandRepository
    {
        IQueryable<Wand> Wands { get; }
     }

    
}
