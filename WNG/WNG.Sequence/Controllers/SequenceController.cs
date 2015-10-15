using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WNG.Sequence.Models;

namespace WNG.Sequence.Controllers
{
    public class SequenceController : Controller
    {
        public ActionResult CreateSequence()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSequence(SequenceRequest model)
        {
            if (!ModelState.IsValid)
                return View(model);

            return RedirectToAction("ShowResult", new { number = model.Number });

        }

        public ActionResult ShowResult(int number)
        {
            var calculator = new SequenceCalculator();
            try
            {
                var result = calculator.Calculate(number);
                return View(result);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }

    }
}