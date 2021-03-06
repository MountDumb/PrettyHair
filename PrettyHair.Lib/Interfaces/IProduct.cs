﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.Lib.Interfaces
{
    public interface IProduct
    {
        int ProductId { get; }
        decimal Price { get; set; }
        string Description { get; set; }
        int Quantity { get; set; }
    }
} 
