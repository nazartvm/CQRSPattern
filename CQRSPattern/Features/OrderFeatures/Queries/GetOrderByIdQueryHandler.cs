using CQRSPattern.Features.OrderFeatures.ViewModels.RequestModels;
using CQRSPattern.Features.OrderFeatures.ViewModels.ResponseModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSPattern.Features.OrderFeatures.Queries
{
    public class GetOrderByIdQueryHandler:IRequestHandler<GetOrderbyIdRequestModel,GetOrderByIdResponseModel>
    {
        public async Task<GetOrderByIdResponseModel> Handle(GetOrderbyIdRequestModel request,CancellationToken cancellationToken)
        {
            var orderDetails = new GetOrderByIdResponseModel();
            return orderDetails;
        }
    }
}
