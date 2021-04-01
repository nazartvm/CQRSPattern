using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSPattern.Features.OrderFeatures.ViewModels.RequestModels;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public IActionResult MakeOrder([FromBody] MakeOrderRequestModel model)
        {
            var response = _mediator.Send(model);
            return Ok(response);
        }
        [HttpGet]
        public IActionResult OrderDetails([FromQuery]GetOrderbyIdRequestModel model)
        {
            var response = _mediator.Send(model);
            return Ok(response);
        }
    }
}