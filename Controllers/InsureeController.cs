using System.Collections.Generic;
using System.Web.Mvc;
using Mvc_Project.Models;

namespace Mvc_Project.Controllers
{
    public class InsureeController : Controller
    {
        private static List<Insuree> insurees = new List<Insuree>();

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                insurees.Add(insuree);
                return RedirectToAction("Admin");
            }
            return View(insuree);
        }

        public ActionResult Admin()
        {
            return View(insurees);
        }

        private decimal CalculateQuote(Insuree insuree)
        {
            decimal total = 50m;

            // Age-based adjustments
            if (insuree.Age <= 18)
            {
                total += 100;
            }
            else if (insuree.Age >= 19 && insuree.Age <= 25)
            {
                total += 50;
            }
            else if (insuree.Age >= 26)
            {
                total += 25;
            }

            // Car year adjustments
            if (insuree.CarYear < 2000)
            {
                total += 25;
            }
            else if (insuree.CarYear > 2015)
            {
                total += 25;
            }

            // Car make and model adjustments
            if (insuree.CarMake.ToLower() == "porsche")
            {
                total += 25;
                if (insuree.CarModel.ToLower() == "911 carrera")
                {
                    total += 25;
                }
            }

            // Speeding tickets adjustment
            total += insuree.SpeedingTickets * 10;

            // DUI adjustment
            if (insuree.DUI)
            {
                total *= 1.25m;
            }

            // Full coverage adjustment
            if (insuree.FullCoverage)
            {
                total *= 1.50m;
            }

            return total;
        }
    }
}
