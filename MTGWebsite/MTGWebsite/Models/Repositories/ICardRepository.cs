using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTGWebsite.Models.Repositories
{
    public interface ICardRepository
    {
        // C r e a t e
        public Card Add(Card card);


        // R e a d
        IQueryable<Card>    GetAllCards();
        Card                GetCardById(int cardid);
        IQueryable<Card>    GetCardsByKeyword(string keyword);

        // U p d a t e

        public Card UpdateCard(Card card);

        // D e l e t e

        public bool DeleteCard(int id);
    }
}
