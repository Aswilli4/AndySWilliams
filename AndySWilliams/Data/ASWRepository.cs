using AndySWilliams.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndySWilliams.Data
{
    public class ASWRepository : IASWRepository
    {
        private readonly ASWContext _ctx;
        public ASWRepository(ASWContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Family> GetAllFamilyMembers()
        {
            return _ctx.Families
                       .ToList();
        }

    }
}
