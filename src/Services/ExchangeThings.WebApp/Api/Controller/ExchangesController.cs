using ExchangeThings.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExchangeThings.WebApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExchangesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] ExchangeModel exchangeModel)
        {
            return Ok(new { success = true });
        }
    }
}
