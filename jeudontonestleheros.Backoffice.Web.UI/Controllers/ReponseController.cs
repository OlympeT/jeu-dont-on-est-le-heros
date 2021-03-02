using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.Data;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheros.Backoffice.Web.UI.Controllers
{
    public class ReponseController : Controller
    {
        // Recupere le context de connection a la base
        private readonly DefaultContext _context = null;

        public ReponseController(DefaultContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            this.ViewBag.QuestionList = this._context.Questions.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Reponse reponse)
        {
            if (this.ModelState.IsValid)
            {
                this._context.Reponses.Add(reponse);
                this._context.SaveChanges();
            }
            this.ViewBag.QuestionList = this._context.Questions.ToList();
            return View(reponse);
        }
    }
}