using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.Data;
using jeudontonestleheros.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheros.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        // Recupere le context de connection a la base
        private readonly DefaultContext _context = null;

        public AventureController(DefaultContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            this.ViewBag.monTitre = "Aventure";

            // Requete Linq
            var query = from item in this._context.Aventures
                        select item;
            var maList = query.ToList();

            return View(maList);
        }
    }
}