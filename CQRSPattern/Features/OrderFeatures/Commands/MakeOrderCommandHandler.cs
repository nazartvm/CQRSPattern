using CQRSPattern.Features.OrderFeatures.ViewModels.RequestModels;
using CQRSPattern.Features.OrderFeatures.ViewModels.ResponseModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSPattern.Features.OrderFeatures.Commands
{
    public class MakeOrderCommandHandler:IRequestHandler<MakeOrderRequestModel,MakeOrderResponseModel>
    {
        public async Task<MakeOrderResponseModel> Handle(MakeOrderRequestModel request,CancellationToken cancellationToken)
        {
            var result = new MakeOrderResponseModel()
            {
                IsSuccess = true,
                OrderId = new Guid("fdfdfew5454546654dsf546")
            };
            return result;
        }
    }
}
