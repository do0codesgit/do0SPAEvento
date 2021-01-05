using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using do0.Models;

namespace do0.Controllers
{
    public class do0TipoEventosController : Controller
    {
        private do0Context db = new do0Context();

        // GET: do0TipoEventos
        public ActionResult Index()
        {
            return View(db.do0TipoEventos.ToList());
        }

        // GET: do0TipoEventos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            do0TipoEvento do0TipoEvento = db.do0TipoEventos.Find(id);
            if (do0TipoEvento == null)
            {
                return HttpNotFound();
            }
            return View(do0TipoEvento);
        }

        // GET: do0TipoEventos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: do0TipoEventos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "do0TipoEventoId,NomeEvento,Observacoes")] do0TipoEvento do0TipoEvento)
        {
            if (ModelState.IsValid)
            {
                db.do0TipoEventos.Add(do0TipoEvento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(do0TipoEvento);
        }

        // GET: do0TipoEventos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            do0TipoEvento do0TipoEvento = db.do0TipoEventos.Find(id);
            if (do0TipoEvento == null)
            {
                return HttpNotFound();
            }
            return View(do0TipoEvento);
        }

        // POST: do0TipoEventos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "do0TipoEventoId,NomeEvento,Observacoes")] do0TipoEvento do0TipoEvento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(do0TipoEvento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(do0TipoEvento);
        }

        // GET: do0TipoEventos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            do0TipoEvento do0TipoEvento = db.do0TipoEventos.Find(id);
            if (do0TipoEvento == null)
            {
                return HttpNotFound();
            }
            return View(do0TipoEvento);
        }

        // POST: do0TipoEventos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            do0TipoEvento do0TipoEvento = db.do0TipoEventos.Find(id);
            db.do0TipoEventos.Remove(do0TipoEvento);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
