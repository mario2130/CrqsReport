using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using CqrsMultipleResorce.Application.Product.Queries;

namespace CqrsMultipleResorce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        readonly IMediator _mediator;

        public ProductsController(IMediator mediator) => _mediator = mediator;

        public async Task<IActionResult> GetAllProduct()
        {
            return Ok(await _mediator.Send(new GetAllProductsQuery()));
        }
    }
}
