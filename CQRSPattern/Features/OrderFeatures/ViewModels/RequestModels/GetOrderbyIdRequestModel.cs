using CQRSPattern.Features.OrderFeatures.ViewModels.ResponseModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSPattern.Features.OrderFeatures.ViewModels.RequestModels
{
    public class GetOrderbyIdRequestModel:IRequest<GetOrderByIdResponseModel>
    {
        public Guid OrderId { get; set; }
    }
}
