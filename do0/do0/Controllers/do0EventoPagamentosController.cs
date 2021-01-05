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
    public class do0EventoPagamentosController : Controller
    {
        private do0Context db = new do0Context();

        // GET: do0EventoPagamentos
        public ActionResult Index()
        {
            return View(db.do0EventoPagamento.ToList());
        }

        // GET: do0EventoPagamentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            do0EventoPagamento do0EventoPagamento = db.do0EventoPagamento.Find(id);
            if (do0EventoPagamento == null)
            {
                return HttpNotFound();
            }
            return View(do0EventoPagamento);
        }

        // GET: do0EventoPagamentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: do0EventoPagamentos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "do0EventoPagamentoId,NomePagamento,Observacoes,Email,Senha,EmailSandbox,SenhaSandbox")] do0EventoPagamento do0EventoPagamento)
        {
            if (ModelState.IsValid)
            {
                db.do0EventoPagamento.Add(do0EventoPagamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(do0EventoPagamento);
        }

        // GET: do0EventoPagamentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            do0EventoPagamento do0EventoPagamento = db.do0EventoPagamento.Find(id);
            if (do0EventoPagamento == null)
            {
                return HttpNotFound();
            }
            return View(do0EventoPagamento);
        }

        // POST: do0EventoPagamentos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "do0EventoPagamentoId,NomePagamento,Observacoes,Email,Senha,EmailSandbox,SenhaSandbox")] do0EventoPagamento do0EventoPagamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(do0EventoPagamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(do0EventoPagamento);
        }

        // GET: do0EventoPagamentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            do0EventoPagamento do0EventoPagamento = db.do0EventoPagamento.Find(id);
            if (do0EventoPagamento == null)
            {
                return HttpNotFound();
            }
            return View(do0EventoPagamento);
        }

        // POST: do0EventoPagamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            do0EventoPagamento do0EventoPagamento = db.do0EventoPagamento.Find(id);
            db.do0EventoPagamento.Remove(do0EventoPagamento);
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
