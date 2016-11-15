using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.Lib
{
    public interface IProduct
    {
        int ProductId { get; set; }
        decimal Price { get; set; }
        string Description { get; set; }
    }
}
