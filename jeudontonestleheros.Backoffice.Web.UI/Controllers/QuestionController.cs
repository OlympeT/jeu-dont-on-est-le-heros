using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.Data;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheros.Backoffice.Web.UI.Controllers
{
    public class QuestionController : Controller
    {
        // Recupere le context de connection a la base
        private readonly DefaultContext _context = null;

        public QuestionController(DefaultContext context)
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
            this.ViewBag.ParagrapheList = this._context.Paragraphes.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Question question)
        {
            if (this.ModelState.IsValid)
            {
                this._context.Questions.Add(question);
                this._context.SaveChanges();
            }
            this.ViewBag.ParagrapheList = this._context.Paragraphes.ToList();
            return View(question);
        }
    }
}