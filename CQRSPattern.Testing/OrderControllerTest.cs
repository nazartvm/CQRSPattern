using CQRSPattern.Controllers;
using CQRSPattern.Features.OrderFeatures.ViewModels.RequestModels;
using CQRSPattern.Features.OrderFeatures.ViewModels.ResponseModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CQRSPattern.Testing
{
    public class OrderControllerTest
    {
        private Mock<IMediator> Mediator;
        public OrderControllerTest()
        {
            Mediator = new Mock<IMediator>();
        }
        [Fact]
        public void MakeOrder_Success_Result()
        {
            var makeOrderRequestModel = new MakeOrderRequestModel();
            Mediator.Setup(x => x.Send(It.IsAny<MakeOrderRequestModel>(), new System.Threading.CancellationToken())).
                ReturnsAsync(new MakeOrderResponseModel { IsSuccess = true, OrderId = Guid.NewGuid() });
            var orderController = new OrderController(Mediator.Object);
            //Action
            IActionResult result = orderController.MakeOrder(makeOrderRequestModel);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
