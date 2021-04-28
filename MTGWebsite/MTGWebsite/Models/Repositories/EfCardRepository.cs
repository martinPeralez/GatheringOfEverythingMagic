using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTGWebsite.Models.Repositories
{
    public class EfCardRepository : ICardRepository
    {
        //   F i e l d s   &   P r o p e r t i e s

        private AppDbContext _context;

        //   C o n s t r u c t o r s

        public EfCardRepository(AppDbContext context)
        {
            _context = context;
        }

        public Card Add(Card card)
        {

            _context.Cards.Add(card);
            _context.SaveChanges();
            return card;
        }

        public bool DeleteCard(int id)
        {
            Card cardToDelete = _context.Cards.Find(id);
            if(cardToDelete == null)
            {
                return false;
            }
            _context.Cards.Remove(cardToDelete);
            _context.SaveChanges();
            return true;
        }

        //   M e t h o d s
        public IQueryable<Card> GetAllCards()
        {
            return _context.Cards;
        }

        public Card GetCardById(int cardid)
        {
            return _context.Cards.Where(p => p.Id == cardid).FirstOrDefault();
        }

        public IQueryable<Card> GetCardsByKeyword(string keyword)
        {
            return _context.Cards.Where(p => p.Name.Contains(keyword) || p.Type.Contains(keyword));
        }

        public Card UpdateCard(Card card)
        {
            Card cardToUpdate = _context.Cards.SingleOrDefault(p => p.Id == card.Id);
            if(cardToUpdate != null)
            {
                cardToUpdate.Name = card.Name;
                cardToUpdate.ManaCost = card.ManaCost;
                cardToUpdate.ConvertedMana = card.ConvertedMana;
                cardToUpdate.Type = card.Type;
                cardToUpdate.CardText = card.CardText;
                cardToUpdate.FlavorText = card.FlavorText;
                cardToUpdate.Expansion = card.Expansion;
                cardToUpdate.Rarity = card.Rarity;
                cardToUpdate.CardNumber = card.CardNumber;
                cardToUpdate.Image = card.Image;
                cardToUpdate.Power = card.Power;
                cardToUpdate.Toughness = card.Toughness;
                _context.SaveChanges();
            }
            return cardToUpdate;
        }
    }
}
