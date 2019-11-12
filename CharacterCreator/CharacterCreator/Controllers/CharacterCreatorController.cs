using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CharacterCreator.Controllers
{
    public class CharacterCreatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DDCreator()
        {
            return View();
        }
    }
}