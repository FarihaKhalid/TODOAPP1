using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SugarBItApplication2.Models;
using SugarBItApplication2.Services;



    namespace SugarBItApplication2.Controllar

{
    public class AuctionsController : Controller
    {
        private AuctionsServices _serv = new AuctionsServices();
        private SugerBidAppContext _db = new SugerBidAppContext(); 


        public IActionResult Index()
        {
            var c = _db.Auctions;
            return View(c);
        }



        public ActionResult Update(int id)
        {
            Auctions cc = _db.Auctions.Find(id);

            return View(cc);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id,Auctions bt)
        {
            string error = string.Empty;

            if (ModelState.IsValid)
            {
                bool isSuccess = _serv.UpdateAuction(id,bt);
                TempData["AlertCSS"] = isSuccess ? "alert success" : "alert error";

                if (!isSuccess)
                    ModelState.AddModelError("", error);
                else
                    TempData["OutputMessage"] = "Record Successfully Updated";

                if (ModelState.IsValid)
                    return RedirectToAction("Index");
            }

            return View();
        }



        public ActionResult Create()
        {

            return View();
        }



        public ActionResult Delete(int id)
        {
            Auctions cc = _db.Auctions.Find(id);
            if (cc != null)
            {
                _db.Auctions.Remove(cc);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
          
        }


       






        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Auctions bt)
        {
            string error = string.Empty;

            if (ModelState.IsValid)
            {
                bool isSuccess = _serv.CreateAuction(bt);
                TempData["AlertCSS"] = isSuccess ? "alert success" : "alert error";

                if (!isSuccess)
                    ModelState.AddModelError("", error);
                else
                    TempData["OutputMessage"] = "Record Successfully Created";

                if (ModelState.IsValid)
                    return RedirectToAction("Index");
            }

            return View();
        }

      


    }   
}