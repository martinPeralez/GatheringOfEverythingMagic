﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MTGWebsite.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MTGWebsite.Controllers
{
    public class HomeController : Controller
    {
        //   F i e l d s   &   P r o p e r t i e s



        //   C o n s t r u c t o r s

        //   M e t h o d s

        public IActionResult Index()
        {
            return View();
        }

    }
}
