using Ocp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Order
{
    internal class Order(Guid id, string name, float amount, DiscountInterface discount = null)
    {
        public Guid Id { get; set; } = id;
        public string Name { get; set; } = name;
        public float Amount { get; set; } = amount;
        public DiscountInterface Discount { get; set; } = discount;


        public void setDiscount(DiscountInterface discount)
        {
            this.Discount = discount;
        }

        //Strategy
        public float getAmount()
        {
            if(this.Discount != null)
            {
                this.Amount = this.Discount.apply(this.Amount);
            }

            return this.Amount;
        }
    }
}
