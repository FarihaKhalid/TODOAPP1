using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SugarBItApplication2.Models;
using SugarBItApplication2.Services;

namespace SugarBItApplication2.Controllers
{
    public class BatchController : Controller
    {
        private BatchService _serv = new BatchService();
        private SugerBidAppContext _db = new SugerBidAppContext();


        public ActionResult Index()
        {
            return View();
        }




        public ActionResult Update(int id)
        {
            Batchs cc = _db.Batchs.Find(id);

            return View(cc);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, Batchs bt)
        {
            string error = string.Empty;

            if (ModelState.IsValid)
            {
                bool isSuccess = _serv.UpdateBatchs(id, bt);
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Batchs bt)
        {
            string error = string.Empty;

            if (ModelState.IsValid)
            {
                bool isSuccess = _serv.CreateBatch(bt);
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



        public ActionResult Delete(int id)
        {
            Batchs cc = _db.Batchs.Find(id);
            if (cc != null)
            {
                _db.Batchs.Remove(cc);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");

        }


       



    }
}