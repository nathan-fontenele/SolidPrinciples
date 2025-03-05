using Ocp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Order
{
    internal class FixedDiscount : DiscountInterface
    {
        private float DiscountValue { get; set; }

        public FixedDiscount(float discountValue)
        {
            DiscountValue = discountValue;    
        }

        public float apply(float orderAmount)
        {
            if (DiscountValue > orderAmount)
            {
                throw new Exception("O desconto não pode ser maior que o valor do produto.");
            }

            return orderAmount - DiscountValue;
        }
    }
}
