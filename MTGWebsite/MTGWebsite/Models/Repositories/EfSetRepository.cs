using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTGWebsite.Models.Repositories
{
    public class EfSetRepository : ISetRepository
    {
        // F i e l d s  &  P r o p e r t i e s

        private AppDbContext _context;

        // C o n s t r u c t o r s

        public EfSetRepository(AppDbContext context)
        {
            _context = context;
        }

        // M e t h o d s
        public IQueryable<Set>  GetAllSets()
        {
            return _context.Sets;
        }

        public Set              GetSetById(int setId)
        {
            return _context.Sets.Where(s => s.Id == setId).FirstOrDefault();
        }

        public IQueryable<Set>  GetSetsByKeyword(string keyword)
        {
            return _context.Sets.Where(s => s.Name.Contains(keyword));
        }
    }
}
