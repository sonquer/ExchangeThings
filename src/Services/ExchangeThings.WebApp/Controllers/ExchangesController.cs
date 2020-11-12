using Microsoft.AspNetCore.Mvc;

namespace ExchangeThings.WebApp.Controllers
{
    public class ExchangesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
