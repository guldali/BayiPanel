using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using Bootstrap.Model;
using System.Web.Helpers;
using System.Collections;
using Newtonsoft.Json;

namespace Bootstrap.Controllers
{
    public class DashboardController : Controller
    {
        BlogDB db = new BlogDB();       
        // GET: Dashboard
        public ActionResult Index()
        {
            var context = new BlogDB();
            // var result = (from c in context.Durumlar select c);
            var OnlineOfflineResult = context.Durumlar.Where(f=>f.Tip==1).ToList();
            ViewBag.OnlineOfflineResult = JsonConvert.SerializeObject(OnlineOfflineResult);

            var UrunFarklariResult = context.Durumlar.Where(f => f.Tip == 2).ToList();
            ViewBag.UrunFarklariResult = JsonConvert.SerializeObject(UrunFarklariResult);

            var SatisFarklariResult = context.Durumlar.Where(f => f.Tip == 3).ToList();
            ViewBag.SatisfarklariResult = JsonConvert.SerializeObject(SatisFarklariResult);

            var VeriGonderenlerResult = context.Durumlar.Where(f => f.Tip == 4).ToList();
            ViewBag.VeriGonderenlerResult = JsonConvert.SerializeObject(VeriGonderenlerResult);
            return View();



        }

        public ActionResult OnlineOfflineDetay() {
            return View();
        }

        public ActionResult UrunDetay() {
            return View();
        }

        public ActionResult SatısAnalizi() {
            return View();

        }
        

        public ActionResult VeriAnalizi() {
            return View();
        }

        public ActionResult Ciro() {
            return View();
        }

        public ActionResult BayiCiro() {
          
            
             return View();
        }
    }
       
    }
