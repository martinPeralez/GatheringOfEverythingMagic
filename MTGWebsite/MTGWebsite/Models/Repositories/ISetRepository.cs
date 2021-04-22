using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTGWebsite.Models.Repositories
{
    public interface ISetRepository
    {
        // C r e a t e


        // R e a d
        IQueryable<Set>     GetAllSets();
        Set                 GetSetById(int cardId);
        IQueryable<Set>     GetSetsByKeyword(string keyword);

        // U p d a t e


    }
}
