using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.Lib
{
    public class Product : IProduct
    {
        #region Fields
        private int _productId;
        private decimal _price;
        private string _description;
        #endregion

        #region Properties
        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        #endregion
        public Product(int productId, decimal price, string description)
        {
            _productId = productId;
            _price = price;
            _description = description;
        }
    }
}
