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
    public class do0EventosController : Controller
    {
        private do0Context db = new do0Context();

        // GET: do0Eventos
        public ActionResult Index()
        {
            var do0Evento = db.do0Eventos.Include(d => d.do0EventoPagamentos).Include(d => d.do0TipoEventos);
            return View(do0Evento.ToList());
        }

        // GET: do0Eventos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            do0Evento do0Evento = db.do0Eventos.Find(id);
            if (do0Evento == null)
            {
                return HttpNotFound();
            }
            return View(do0Evento);
        }

        // GET: do0Eventos/Create
        public ActionResult Create()
        {
            ViewBag.do0EventoPagamentoId = new SelectList(db.do0EventoPagamento, "do0EventoPagamentoId", "NomePagamento");
            ViewBag.do0TipoEventoId = new SelectList(db.do0TipoEventos, "do0TipoEventoId", "NomeEvento");
            return View();
        }

        // POST: do0Eventos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "do0EventoId,StatusDoEvento,DataCadastro,do0Avatar,UserName,do0TipoEventoId,do0EventoPagamentoId,DataNascimento,NomeCompleto,ResponsavelEvento,NomeHomenageado,CPF,Identidade,Endereco,Email,Telefone1,Telefone2,Telefone3,Observacoes")] do0Evento do0Evento)
        {
            if (ModelState.IsValid)
            {
                db.do0Eventos.Add(do0Evento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.do0EventoPagamentoId = new SelectList(db.do0EventoPagamento, "do0EventoPagamentoId", "NomePagamento", do0Evento.do0EventoPagamentoId);
            ViewBag.do0TipoEventoId = new SelectList(db.do0TipoEventos, "do0TipoEventoId", "NomeEvento", do0Evento.do0TipoEventoId);
            return View(do0Evento);
        }

        // GET: do0Eventos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            do0Evento do0Evento = db.do0Eventos.Find(id);
            if (do0Evento == null)
            {
                return HttpNotFound();
            }
            ViewBag.do0EventoPagamentoId = new SelectList(db.do0EventoPagamento, "do0EventoPagamentoId", "NomePagamento", do0Evento.do0EventoPagamentoId);
            ViewBag.do0TipoEventoId = new SelectList(db.do0TipoEventos, "do0TipoEventoId", "NomeEvento", do0Evento.do0TipoEventoId);
            return View(do0Evento);
        }

        // POST: do0Eventos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "do0EventoId,StatusDoEvento,DataCadastro,do0Avatar,UserName,do0TipoEventoId,do0EventoPagamentoId,DataNascimento,NomeCompleto,ResponsavelEvento,NomeHomenageado,CPF,Identidade,Endereco,Email,Telefone1,Telefone2,Telefone3,Observacoes")] do0Evento do0Evento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(do0Evento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.do0EventoPagamentoId = new SelectList(db.do0EventoPagamento, "do0EventoPagamentoId", "NomePagamento", do0Evento.do0EventoPagamentoId);
            ViewBag.do0TipoEventoId = new SelectList(db.do0TipoEventos, "do0TipoEventoId", "NomeEvento", do0Evento.do0TipoEventoId);
            return View(do0Evento);
        }

        // GET: do0Eventos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            do0Evento do0Evento = db.do0Eventos.Find(id);
            if (do0Evento == null)
            {
                return HttpNotFound();
            }
            return View(do0Evento);
        }

        // POST: do0Eventos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            do0Evento do0Evento = db.do0Eventos.Find(id);
            db.do0Eventos.Remove(do0Evento);
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
