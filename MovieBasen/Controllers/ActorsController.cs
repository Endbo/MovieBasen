using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieBasen.Models;

namespace MovieBasen.Controllers
{
    public class ActorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Actors
        [Authorize(Roles="Admin")]
        public ActionResult Index()
        {
            return View(db.Actors.OrderBy(s => s.FirstName).ToList());
        }

        // GET: Actors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actor actor = db.Actors.Find(id);
            if (actor == null)
            {
                return HttpNotFound();
            }
            return View(actor);
        }

        // GET: Actors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Actors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Actor actor)
        {
            if (ModelState.IsValid)
            {
                db.Actors.Add(actor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(actor);
        }

        // GET: Actors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actor actor = db.Actors.Find(id);
            if (actor == null)
            {
                return HttpNotFound();
            }
            return View(actor);
        }

        // POST: Actors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Actor actor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actor);
        }

        // GET: Actors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actor actor = db.Actors.Find(id);
            if (actor == null)
            {
                return HttpNotFound();
            }
            return View(actor);
        }

        // POST: Actors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Actor actor = db.Actors.Find(id);
            db.Actors.Remove(actor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
