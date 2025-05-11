using Microsoft.AspNetCore.Mvc;
using MVC.Entidades;
using MVC.Servicios;

namespace ModeloParcialPaniales_PW3.Controllers
{
    public class PanialController : Controller

    {

        private IPanialesServicio _panialesServicio;

         public PanialController(IPanialesServicio panialesServicio)
        {
            _panialesServicio = panialesServicio;
        }

        public IActionResult Resultados()
        {
            var resultados = _panialesServicio.obtenerPaniales();

            // Verifica si la lista es nula o está vacía
            if (resultados == null || !resultados.Any())
            {
                ViewBag.Message = "No hay resultados disponibles.";
                return View("Resultados", new List<Panial>());
            }
            else
            {
                ViewBag.Message = "Resultados disponibles.";
                return View("Resultados", resultados);
            }
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

                string tamanio = _panialesServicio.CalcularPaniales(panial.pesoDelNinio, panial.edadDelNinio);
                panial.tamanio = tamanio;
                _panialesServicio.AgregarPanial(panial);

                return RedirectToAction("Resultados");

            }
            else
            {
                ViewBag.Mensaje = "Error en los datos ingresados.";

            }
            return View("CalcularPanial");

        }
    }
}
