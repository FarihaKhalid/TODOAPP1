using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SugarBItApplication2.Models;
using SugarBItApplication2.Services;

namespace SugarBItApplication2.Controllers
{
    public class GradesController : Controller
    {
        private GradesService _serv = new GradesService();

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }


        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Grades bt)
        {
            string error = string.Empty;

            if (ModelState.IsValid)
            {
                bool isSuccess = _serv.CreateGrades(bt);
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