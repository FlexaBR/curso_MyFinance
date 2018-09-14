using Microsoft.AspNetCore.Mvc;

namespace MyFinance.Controllers
{
    public class PlanoContaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}