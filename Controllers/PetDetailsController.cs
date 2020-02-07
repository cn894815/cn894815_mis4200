using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using cn894815_mis4200.DAL;
using cn894815_mis4200.Models;

namespace cn894815_mis4200.Controllers
{
    public class PetDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: PetDetails
        public ActionResult Index()
        {
            var petDetails = db.PetDetails.Include(p => p.Owner).Include(p => p.Pet);
            return View(petDetails.ToList());
        }

        // GET: PetDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetDetail petDetail = db.PetDetails.Find(id);
            if (petDetail == null)
            {
                return HttpNotFound();
            }
            return View(petDetail);
        }

        // GET: PetDetails/Create
        public ActionResult Create()
        {
            ViewBag.ownerID = new SelectList(db.Owners, "ownerID", "firstName");
            ViewBag.PetID = new SelectList(db.Pets, "petID", "firstName");
            return View();
        }

        // POST: PetDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "petDetailID,weight,breed,lastVisit,PetID,ownerID")] PetDetail petDetail)
        {
            if (ModelState.IsValid)
            {
                db.PetDetails.Add(petDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ownerID = new SelectList(db.Owners, "ownerID", "firstName", petDetail.ownerID);
            ViewBag.PetID = new SelectList(db.Pets, "petID", "firstName", petDetail.PetID);
            return View(petDetail);
        }

        // GET: PetDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetDetail petDetail = db.PetDetails.Find(id);
            if (petDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.ownerID = new SelectList(db.Owners, "ownerID", "firstName", petDetail.ownerID);
            ViewBag.PetID = new SelectList(db.Pets, "petID", "firstName", petDetail.PetID);
            return View(petDetail);
        }

        // POST: PetDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "petDetailID,weight,breed,lastVisit,PetID,ownerID")] PetDetail petDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(petDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ownerID = new SelectList(db.Owners, "ownerID", "firstName", petDetail.ownerID);
            ViewBag.PetID = new SelectList(db.Pets, "petID", "firstName", petDetail.PetID);
            return View(petDetail);
        }

        // GET: PetDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetDetail petDetail = db.PetDetails.Find(id);
            if (petDetail == null)
            {
                return HttpNotFound();
            }
            return View(petDetail);
        }

        // POST: PetDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PetDetail petDetail = db.PetDetails.Find(id);
            db.PetDetails.Remove(petDetail);
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
