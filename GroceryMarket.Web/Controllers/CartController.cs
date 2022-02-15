using GroceryMarket.ApplicationCore.BaseClasses;
using GroceryMarket.ApplicationCore.DTO;
using GroceryMarket.ApplicationCore.Interfaces;
using GroceryMarket.ApplicationCore.Services;
using GroceryMarket.Infrastructure.Implementations.ProductRules;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryMarket.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ITerminalService _terminal;
        private readonly IPricingService _service;
        private readonly IRulable _executor;
        // for simplicity:
        private readonly List<IRule> _rules = new List<IRule>(new List<IRule> { new ProductARule(), new ProductCRule() });
        
        public CartController(ITerminalService terminal, IPricingService service, IRulable executor)
        {
            _terminal = terminal;
            _service = service;
            _executor = executor;
        }

        // POST api/<CartController>
        // Could be made async if needed.
        // Client posts products, server calculates cost and sends result to client side
        [HttpPost]
        public IActionResult Post([FromForm]List<ProductBase> products)
        {
            if (products.Any())
            {
                var result = _terminal.Calculate(_service, products, _rules, _executor);

                return Ok(new GroceryCartResultModel(result, products));
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
