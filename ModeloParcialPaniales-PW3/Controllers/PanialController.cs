using Microsoft.AspNetCore.Mvc;
using MVC.Entidades;

namespace ModeloParcialPaniales_PW3.Controllers
{
    public class PanialController : Controller
    {
        public IActionResult Resultados()
        {
            return View();
        }

        public IActionResult CalcularPanial()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult CalcularPanial(Panial panial)
        {
            if (ModelState.IsValid)
            {
               
            }
            return RedirectToAction("Resultados");
        }
    }
}
