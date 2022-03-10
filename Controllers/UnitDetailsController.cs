using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web.Factory;
using Web.Managers;
using Web.Models;

namespace Web.Controllers
{
    public class UnitDetailsController : Controller
    {
        private CondoDataEntities db = new CondoDataEntities();

        // GET: UnitDetails
        public ActionResult Index()
        {
            var unitDetails = db.UnitDetails.Include(u => u.UnitType);
            return View(unitDetails.ToList());
        }

        // GET: UnitDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnitDetail unitDetail = db.UnitDetails.Find(id);
            if (unitDetail == null)
            {
                return HttpNotFound();
            }
            return View(unitDetail);
        }

        // GET: UnitDetails/Create
        public ActionResult Create()
        {
            ViewBag.UnitTypeID = new SelectList(db.UnitTypes, "Id", "UnitType1");
            return View();
        }

        // POST: UnitDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UnitName,Furnishing,Bedroom,Bath,FloorArea,Net_Price,UnitTypeID")] UnitDetail unitDetail)
        {
            if (ModelState.IsValid)
            {
                CondoDataManagerFactory condoFactory = new CondoDataManagerFactory();
                ICondoDataManager condomanager = condoFactory.GetCondoDataManager(unitDetail.UnitTypeID);
                unitDetail.Bedroom = condomanager.GetBedroom();
                unitDetail.Bath = condomanager.GetBath();
                unitDetail.FloorArea = condomanager.GetFloorArea();
                unitDetail.Net_Price = condomanager.GetNetPrice();
                db.UnitDetails.Add(unitDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UnitTypeID = new SelectList(db.UnitTypes, "Id", "UnitType1", unitDetail.UnitTypeID);
            return View(unitDetail);
        }

        // GET: UnitDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnitDetail unitDetail = db.UnitDetails.Find(id);
            if (unitDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.UnitTypeID = new SelectList(db.UnitTypes, "Id", "UnitType1", unitDetail.UnitTypeID);
            return View(unitDetail);
        }

        // POST: UnitDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UnitName,Furnishing,Bedroom,Bath,FloorArea,Net_Price,UnitTypeID")] UnitDetail unitDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unitDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UnitTypeID = new SelectList(db.UnitTypes, "Id", "UnitType1", unitDetail.UnitTypeID);
            return View(unitDetail);
        }

        // GET: UnitDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnitDetail unitDetail = db.UnitDetails.Find(id);
            if (unitDetail == null)
            {
                return HttpNotFound();
            }
            return View(unitDetail);
        }

        // POST: UnitDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UnitDetail unitDetail = db.UnitDetails.Find(id);
            db.UnitDetails.Remove(unitDetail);
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
