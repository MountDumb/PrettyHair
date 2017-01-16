using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Lib.Interfaces;

namespace PrettyHair.Lib.ConcreteProducts
{
    public class Comb : Product, IComb
    {
        public int ProductTypeId { get; set; }

        public Comb()
        {

        }
        public Comb(int productId, decimal price, string description, int productTypeId, int quantity) : base(productId, price, description, quantity)
        {
            this.ProductTypeId = productTypeId;
        }

    }
}
