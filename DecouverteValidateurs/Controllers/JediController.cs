using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DecouverteValidateurs.Controllers
{
    public class JediController : Controller
    {
        // GET: Jedi
        public ActionResult Index()
        {
            return View();
        }

        // GET: Jedi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jedi/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Jedi jedi)
        {
            if (ModelState.IsValid)
            {
                // Enregistrement en bdd

            }
            return this.View(jedi);
           
        }

        // GET: Jedi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Jedi/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Models.Jedi jedi)
        {
            return this.View(jedi);
        }

        // POST: Jedi/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}