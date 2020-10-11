using ExchangeThings.WebApp.Models;
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

        [HttpPost]
        public IActionResult Post(ExchangeModel exchangeModel)
        {
            return View("Index", exchangeModel);
        }
    }
}
