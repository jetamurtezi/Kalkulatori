using Kalkulatori.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kalkulatori.Controllers
{
    public class KalkulatoriPensionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Kalkulatori.Models.KalkulatoriPension model) {
            if (ModelState.IsValid)
            {
                return View("Rezultati", model);
            }
            return View(model);
        }



    }
}
