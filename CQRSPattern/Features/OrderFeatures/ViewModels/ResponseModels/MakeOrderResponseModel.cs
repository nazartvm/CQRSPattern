using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSPattern.Features.OrderFeatures.ViewModels.ResponseModels
{
    public class MakeOrderResponseModel
    {
        public bool IsSuccess { get; set; }
        public Guid OrderId { get; set; }
    }
}
