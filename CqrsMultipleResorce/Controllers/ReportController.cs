using CqrsMultipleResorce.Application.Report.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsMultipleResorce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        readonly IMediator _mediator;
        public ReportController(IMediator mediator)
            => _mediator = mediator;


        [HttpGet("product-in-exists")]
        public async Task<IActionResult> GetProductInExists()
        {
            return Ok(await _mediator.Send(new GetProductInExistQuery()));
        }
    }
}
