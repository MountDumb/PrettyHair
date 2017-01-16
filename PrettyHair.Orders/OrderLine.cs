using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Lib.Interfaces;

namespace PrettyHair.Orders
{
    public class OrderLine : IOrderLine
    {
        private IProduct _product;
        private int _quantity;

        public OrderLine(IProduct product, int quantity)
        {
            _product = product;
            _quantity = quantity;
        }

        public decimal GetSubtotal()
        {
            return _product.Price * _quantity;
        }

        public IProduct GetProduct
        {
            get { return _product; }
        }
    }
}
