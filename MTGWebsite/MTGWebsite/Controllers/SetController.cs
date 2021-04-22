using Microsoft.AspNetCore.Mvc;
using MTGWebsite.Models;
using MTGWebsite.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTGWebsite.Controllers
{
    public class SetController : Controller
    {
        //   F i e l d s   &   P r o p e r t i e s

        private ISetRepository _repository;

        //   C o n s t r u c t o r s

        public SetController(ISetRepository repository)
        {
            _repository = repository;
        }

        //   M e t h o d s

        public IActionResult Index()
        {
            IQueryable<Set> allSets = _repository.GetAllSets();
            return View(allSets);
        }
    }
}
