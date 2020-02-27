using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SugarBItApplication2.Models;
using SugarBItApplication2.Services;

namespace SugarBItApplication2.Controllers
{
    public class CompanysController : Controller
    {
        private CompanysService _serv = new CompanysService();
        private SugerBidAppContext _db = new SugerBidAppContext();
        
        
        
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Delete(int id )
        {
            Companys cc = _db.Companys.Find(id);
                if (cc != null)
            {
                _db.Companys.Remove(cc);
                _db.SaveChanges();

            }
                return RedirectToAction("");
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]  


        public ActionResult Update()
        {
            return View();
        }
        
        
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        
        public ActionResult Update(int id ,Companys bt) {
            string error = String.Empty;
            if (ModelState.IsValid)
            {
                    bool isSuccess = _serv.UpdateCompany(id,bt);
                TempData["AlertCSS"] = isSuccess ? "alert Success" : "alert error";
                if (!isSuccess)
                    ModelState.AddModelError("", error);
                else
                    TempData["OutPutMassage"] = "Record successfully update";
                if (ModelState.IsValid)
                    return RedirectToAction("Index");

            }
            return View();
        }


        public ActionResult Create()
        {
            return View();
        }
        
       
        
        
        
        public ActionResult Create(Companys bt)
        {
            string error = string.Empty;

            if (ModelState.IsValid)
            {
                bool isSuccess = _serv.CreateCompanys(bt);
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