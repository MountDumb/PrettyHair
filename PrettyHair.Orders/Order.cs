using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.Orders
{
    public class Order
    {
        private List<OrderLine> _orderLines;
        private DateTime _dateOfOrdering;

        public Order()
        {
            _orderLines = new List<OrderLine>();
            _dateOfOrdering = DateTime.Now;
        }
    }
}
