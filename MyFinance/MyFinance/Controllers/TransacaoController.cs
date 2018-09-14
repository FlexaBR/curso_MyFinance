using Microsoft.AspNetCore.Mvc;

namespace MyFinance.Controllers
{
    public class TransacaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		public IActionResult Extrato()
		{
			return View();
		}

		public IActionResult Dashboard()
		{
			return View();
		}
    }
}