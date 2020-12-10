using System.Linq;
using ExchangeThings.WebApp.Database;
using Microsoft.AspNetCore.Mvc;

namespace ExchangeThings.WebApp.ViewComponents
{
    public class LatestItem : ViewComponent
    {
        private readonly ExchangeThingsDbContext _exchangeThingsDbContext;

        public LatestItem(ExchangeThingsDbContext exchangeThingsDbContext) => _exchangeThingsDbContext = exchangeThingsDbContext;

        public IViewComponentResult Invoke()
        {
            var latestItem = _exchangeThingsDbContext.ExchangeItemEntities
                .OrderByDescending(e => e.CreatedAt)
                .FirstOrDefault();

            return View("Index", latestItem);
        }
    }
}
