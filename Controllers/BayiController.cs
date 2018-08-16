using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bootstrap.Model;
using Bootstrap.Models;

namespace Bootstrap.Controllers {
    public partial class BayiController : Controller {
        private OpetContext db = new OpetContext();

        // GET: Bayi
        public ActionResult Index() {
            return View(db.Bayis.ToList());
        }

        // GET: Bayi/Details/5
        public ActionResult Details(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BayiKart bayi = db.Bayis.Find(id);
            if (bayi == null) {
                return HttpNotFound();
            }
            return View(bayi);
        }

        // GET: Bayi/Create
        public ActionResult Create() {
            return View();
        }

        // POST: Bayi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Unvan,BayiHost")] BayiKart bayi) {
            if (ModelState.IsValid) {
                db.Bayis.Add(bayi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bayi);
        }

        // GET: Bayi/Edit/5
        public ActionResult Edit(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BayiKart bayi = db.Bayis.Find(id);

            if (bayi == null) {
                return HttpNotFound();
            }
            //return View(bayi);
            // var ieLogLevels = "HttpRequestResponseException, RecoverableError, FatalError, Info, Warning"
            //   .Split(',')
            //   .Select(log => new SelectListItem { Text = log, Value = log });

            //var ieSyncTables = "Log_UrunHareket,Log_UrunFiyatHistory,Log_MarketSatis,Log_MarketSatisHareket,Log_Fatura,Log_FaturaHareket"
            //    .Split(',')
            //    .Select(table => new SelectListItem {
            //        Text = table,
            //        Value = table,
            //        Selected = bayi.SyncTables.Contains(table)
            //    });



            string sTumTablolar = "Log_UrunHareket,Log_UrunFiyatHistory,Log_MarketSatis,Log_MarketSatisHareket,Log_Fatura,Log_FaturaHareket";
            string[] arrTumTablolar = sTumTablolar.Split(new char[] { ',' });

            List<SelectListItem> listeSyncTablolar = new List<SelectListItem>();
            foreach (string tablo in arrTumTablolar) {

                var sel = new SelectListItem();
                sel.Text = tablo;
                sel.Value = tablo;
                sel.Selected = string.IsNullOrEmpty(bayi.SyncTables)
                    ? false
                    : bayi.SyncTables.Contains(tablo);
                listeSyncTablolar.Add(sel);

            }

            string logLevels = "Info,Warning,Error,HttpRequestResponseException,RecoverableError,FatalError";
            string[] arrLogLevels = logLevels.Split(new char[] { ',' });

            List<SelectListItem> listeGunluk = new List<SelectListItem>();
            foreach (string tablo in arrLogLevels) {
                var gun = new SelectListItem();
                gun.Text = tablo;
                gun.Value = tablo;
                gun.Selected =string.IsNullOrEmpty( bayi.LogLevel)
                    ?false
                    :bayi.LogLevel.Contains(tablo);
                listeGunluk.Add(gun);
            }

            return View(new EditBayiControllerModel {
                SyncTables = listeSyncTablolar,
                LogLevels = listeGunluk,
                Bayi = bayi
            });




        }

        // POST: Bayi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Unvan,BayiHost")] BayiKart bayi) {
            if (ModelState.IsValid) {
                db.Entry(bayi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bayi);
        }

        // GET: Bayi/Delete/5
        public ActionResult Delete(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BayiKart bayi = db.Bayis.Find(id);
            if (bayi == null) {
                return HttpNotFound();
            }
            return View(bayi);
        }

        // POST: Bayi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {
            BayiKart bayi = db.Bayis.Find(id);
            db.Bayis.Remove(bayi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
