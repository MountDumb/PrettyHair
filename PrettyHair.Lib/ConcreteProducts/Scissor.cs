using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.Lib.ConcreteProducts
{
    public class Scissor : Product
    {
        public Scissor()
        {

        }
        public Scissor(int productId, decimal price, string description) : base(productId, price, description)
        {
           
        }
      
    }
}
