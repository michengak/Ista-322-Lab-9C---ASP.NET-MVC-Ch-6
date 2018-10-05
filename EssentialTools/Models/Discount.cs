using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class Discount
    {
        public interface IDiscountHelper
        {
            decimal ApplyDiscount(decimal totalParam);

        }
        public class DefaultDiscountHelper : IDiscountHelper
        {
            public decimal ApplyDiscount(decimal totalParam)
            {
                return (totalParam - (DiscountSize / 100m * totalParam));
            }

            public decimal DiscountSize { get; set; }

        }

    }
}