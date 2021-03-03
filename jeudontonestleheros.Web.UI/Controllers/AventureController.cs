using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.Data;
using jeudontonestlehero.Core.Data.Models;
using jeudontonestlehero.Core.Data.DataLayers;
using jeudontonestleheros.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheros.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        // Recupere le context de connection a la base
        private readonly DefaultContext _context = null;
        private RedirectToActionResult result;
        private ParagrapheDataLayer _paragrapheLayer = null;

        public AventureController(DefaultContext context, ParagrapheDataLayer paragrapheDataLayer)
        {
            this._context = context;
            this._paragrapheLayer = paragrapheDataLayer;
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

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create( Aventure aventure)
        {
            if (ModelState.IsValid)
            {
                this._context.Aventures.Add(aventure);
                this._context.SaveChanges();

                result = this.RedirectToAction("BeginNewOne");
            }
            return result;
        }

        public IActionResult BeginNewOne()
        {
            return this.View(this._paragrapheLayer.GetFirst());
        }

        [HttpGet]
        public IActionResult Edit( int id)
        {
            return this.View();
        }
    }
}