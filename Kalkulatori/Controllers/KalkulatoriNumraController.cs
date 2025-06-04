using Kalkulatori.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kalkulatori.Controllers
{
    public class KalkulatoriNumraController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(KalkulatoriNumra model) {
            if (ModelState.IsValid)
            {
                return View("Rezultati", model);
            }
            else {
                return View(model);
            }
        
        }
    }
}
