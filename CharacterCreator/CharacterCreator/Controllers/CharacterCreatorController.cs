using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Models;
using iTextSharp.text.pdf;
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

        public IActionResult GenerateCharacter(DDCharacter character)
        {
            DDCharacterSheet newCharacter = new DDCharacterSheet();
            newCharacter.FillForm(character);
            return View(character);
        }
    }
}