using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.Data;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheros.Backoffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        // Recupere le context de connection a la base
        private readonly DefaultContext _context = null;

        public ParagrapheController(DefaultContext context)
        {
            this._context = context;
        }

        #region Methode Public

        public ActionResult Index()
        {
            // Requete Linq
            var query = from item in this._context.Paragraphes
                        select item;
            var maList = query.ToList();
            return this.View(maList);
        }

        public ActionResult Edit(int id)
        {
           
            Paragraphe paragraphe = null;
            paragraphe = this._context.Paragraphes.First(item => item.Id == id);
            return this.View(paragraphe);
        }

        [HttpPost]
        public ActionResult Edit(Paragraphe paragraphe)
        {
            // Modtifier que si la valeur a changer
            //this._context.Attach<Paragraphe>(paragraphe);
            //this._context.Entry(paragraphe).Property(item => item.Titre).IsModified = true;

            // Tout update
            this._context.Paragraphes.Update(paragraphe);

            this._context.SaveChanges();
            return this.View();
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(Paragraphe paragraphe)
        {
            this._context.Paragraphes.Add(paragraphe);
            this._context.SaveChanges();
            return this.View();
        }
        #endregion
    }
}