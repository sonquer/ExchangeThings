using System.Threading;
using System.Threading.Tasks;
using ExchangeThings.WebApp.Database;
using ExchangeThings.WebApp.Database.Models;
using ExchangeThings.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExchangeThings.WebApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExchangesController : ControllerBase
    {
        private readonly ExchangeThingsDbContext _exchangeThingsDbContext;

        public ExchangesController(ExchangeThingsDbContext exchangeThingsDbContext) => _exchangeThingsDbContext = exchangeThingsDbContext;

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ExchangeModel exchangeModel, CancellationToken cancellationToken)
        {
            await _exchangeThingsDbContext.AddAsync(new ExchangeItemEntity
            {
                Name = exchangeModel.Name,
                Description = exchangeModel.Description,
                IsVisible = exchangeModel.IsVisible
            });

            await _exchangeThingsDbContext.SaveChangesAsync(cancellationToken);

            return Ok(new { success = true });
        }
    }
}