using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srp.Order
{
    internal class Order(Guid id, string name)
    {
        public Guid Id { get; set; } = id;
        public string Name { get; set; } =  name;
    }
}
