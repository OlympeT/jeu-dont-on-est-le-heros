using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestleheros.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheros.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.monTitre = "Aventure";

            List<Aventure> maList = new List<Aventure>();

            maList.Add(new Aventure()
            {
                Id = 1,
                Titre = "Ma premiere aventure"
            });

            maList.Add(new Aventure()
            {
                Id = 2,
                Titre = "Ma seconde aventure"
            });
            return View(maList);
        }
    }
}