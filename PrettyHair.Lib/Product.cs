using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.Lib
{
    public abstract class Product 
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

        public Product()
        {

        }
        public Product(int productId, decimal price, string description)
        {
            _productId = productId;
            _price = price;
            _description = description;
        }

        #region
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
