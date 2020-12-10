using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ExchangeThings.WebApp.Database;
using ExchangeThings.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExchangeThings.WebApp.Controllers
{
    public class ExchangesController : Controller
    {
        private ExchangeThingsDbContext _exchangeThingsDbContext;

        public ExchangesController(ExchangeThingsDbContext exchangeThingsDbContext) => _exchangeThingsDbContext = exchangeThingsDbContext;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List(CancellationToken cancellationToken)
        {
            var entities = (await _exchangeThingsDbContext.ExchangeItemEntities
                .ToListAsync(cancellationToken))
                .Select(e => new ExchangeModel {
                    Name = e.Name,
                    Description = e.Description,
                    IsVisible = e.IsVisible,
                    CreatedAt = e.CreatedAt
                })
                .OrderByDescending(e => e.CreatedAt)
                .ToList();

            return View(entities);
        }
    }
}
