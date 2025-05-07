using Microsoft.AspNetCore.Mvc;

namespace ModeloParcialPaniales_PW3.Controllers
{
    public class PrincipalController : Controller
    {
        public IActionResult Inicio()
        {
            return View();
        }

        
    }
}
