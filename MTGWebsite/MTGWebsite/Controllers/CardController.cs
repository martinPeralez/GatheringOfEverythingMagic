using Microsoft.AspNetCore.Mvc;
using MTGWebsite.Models;
using MTGWebsite.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTGWebsite.Controllers
{
    public class CardController : Controller
    {
        //   F i e l d s   &   P r o p e r t i e s
        private int pageSize = 20;
        private ICardRepository _repository;

        //   C o n s t r u c t o r s

        public CardController(ICardRepository repository)
        {
            _repository = repository;
        }

        //   M e t h o d s

        [HttpGet]
        public IActionResult Add()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Card c)
        {
            _repository.Create(c);
            return RedirectToAction("Index");
        }


        //public IActionResult Index()
        //{
        //    IQueryable<Card> allCards = _repository.GetAllCards();
        //    return View(allCards);
        //}
        public IActionResult Index(int productPage = 1)
        {
            IQueryable<Card> someCards = _repository.GetAllCards()
                                                    .OrderBy(p => p.CardId)
                                                    .Skip((productPage - 1) * pageSize)
                                                    .Take(pageSize);
            return View(someCards);
        }

        public IActionResult Detail(int id)
        {
            Card card = _repository.GetCardById(id);
            if(card != null)
            {
                return View(card);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Search(string keyword)
        {
            IQueryable<Card> cards = _repository.GetCardsByKeyword(keyword);
            return View(cards);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Card card = _repository.GetCardById(id);
            if(card != null)
            {
                return View(card);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Card card)
        {
            _repository.UpdateCard(card);
            return RedirectToAction("Index");
        }
    }
}
