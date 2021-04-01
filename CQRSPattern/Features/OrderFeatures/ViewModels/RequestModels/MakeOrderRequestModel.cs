﻿using CQRSPattern.Features.OrderFeatures.ViewModels.ResponseModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSPattern.Features.OrderFeatures.ViewModels.RequestModels
{
    public class MakeOrderRequestModel:IRequest<MakeOrderResponseModel>
    {
        public Guid Guid { get; set; }
        public string OrderName { get; set; }
        public DateTime DateOrder { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public Guid OrderPersonId { get; set; }
    }
}
