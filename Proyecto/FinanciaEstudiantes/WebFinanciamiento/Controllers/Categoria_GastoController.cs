using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebFinanciamiento.Models;

namespace WebFinanciamiento.Controllers
{
    public class Categoria_GastoController : Controller
    {
        private BD_FinanciamientoEntities db = new BD_FinanciamientoEntities();

        // GET: Categoria_Gasto
        public async Task<ActionResult> Index()
        {
            return View(await db.Categoria_Gasto.ToListAsync());
        }

        // GET: Categoria_Gasto/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria_Gasto categoria_Gasto = await db.Categoria_Gasto.FindAsync(id);
            if (categoria_Gasto == null)
            {
                return HttpNotFound();
            }
            return View(categoria_Gasto);
        }

        // GET: Categoria_Gasto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria_Gasto/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "IDCategoria_Gasto,NCategoria_Gasto")] Categoria_Gasto categoria_Gasto)
        {
            if (ModelState.IsValid)
            {
                db.Categoria_Gasto.Add(categoria_Gasto);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(categoria_Gasto);
        }

        // GET: Categoria_Gasto/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria_Gasto categoria_Gasto = await db.Categoria_Gasto.FindAsync(id);
            if (categoria_Gasto == null)
            {
                return HttpNotFound();
            }
            return View(categoria_Gasto);
        }

        // POST: Categoria_Gasto/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "IDCategoria_Gasto,NCategoria_Gasto")] Categoria_Gasto categoria_Gasto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoria_Gasto).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(categoria_Gasto);
        }

        // GET: Categoria_Gasto/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria_Gasto categoria_Gasto = await db.Categoria_Gasto.FindAsync(id);
            if (categoria_Gasto == null)
            {
                return HttpNotFound();
            }
            return View(categoria_Gasto);
        }

        // POST: Categoria_Gasto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Categoria_Gasto categoria_Gasto = await db.Categoria_Gasto.FindAsync(id);
            db.Categoria_Gasto.Remove(categoria_Gasto);
            await db.SaveChangesAsync();
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
