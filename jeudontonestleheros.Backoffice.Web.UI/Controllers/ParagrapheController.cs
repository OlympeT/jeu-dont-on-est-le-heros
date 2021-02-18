using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheros.Backoffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        private List<Paragraphe> _maList = new List<Paragraphe>()
        {
            new Paragraphe(){Id = 1, Numero = 1, Titre = "un tire 1", Description = " Undescription"},
            new Paragraphe(){Id = 2, Numero = 1, Titre = "un tire 2", Description = " Undescription"},
            new Paragraphe(){Id = 2, Numero = 1, Titre = "un tire 3", Description = " Undescription"},
        };
        #region Methode Public

        public ActionResult Index()
        {         
            return this.View();
        }

        public ActionResult Edit(int id)
        {
            Paragraphe paragraphe = null;
            paragraphe = _maList.First(item => item.Id == id);
            return this.View(paragraphe);
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(Paragraphe paragraphe)
        {
            return this.View();
        }
        #endregion
    }
}