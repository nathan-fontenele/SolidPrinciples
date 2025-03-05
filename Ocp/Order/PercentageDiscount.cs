using Ocp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Order
{
    internal class PercentageDiscount : DiscountInterface
    {
        public float PercentageDiscountValue { get; set; }

        public PercentageDiscount(float percantageDiscount)
        {
            PercentageDiscountValue = percantageDiscount;
        }

        public float apply(float orderAmount)
        {
            if (PercentageDiscountValue > 100 || PercentageDiscountValue < 0)
            {
                throw new Exception("O desconto deve entre 1% e 100%");
            }

            return orderAmount - (orderAmount * PercentageDiscountValue / 100);
        }
    }
}
