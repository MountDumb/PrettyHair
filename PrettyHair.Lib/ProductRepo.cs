using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.Lib
{
    public class ProductRepo
    {
        #region Fields
        //private ICollection<IProduct> _productCol;
        private List<IProduct> _productCol;
        #endregion

        public ProductRepo()
        {
            _productCol = new List<IProduct>();
        }

        #region Methods

        public void AddProduct(IProduct ip)
        {
            _productCol.Add(ip);
        }

        public IList<IProduct> GetProducts()
        {
            return new List<IProduct>(_productCol);
        }

        public IProduct GetProductById(int id)
        {
            if (_productCol.Exists(x => x.ProductId == id))
            {
                return _productCol.Find(x => x.ProductId == id);
            }
            else
            {
                throw new ArgumentNullException();
            }
        } 
               

        public void UpdateProduct(IProduct p)
        {
            IProduct mutablep = _productCol.Find(x => x.ProductId == p.ProductId);
            mutablep.Price = p.Price;
            mutablep.Description = p.Description;
            mutablep.Quantity = p.Quantity;
            //int i = _productCol.FindIndex(x => x.ProductId == p.ProductId);
            //_productCol[i] = (Product)p;
        }
        public void DeleteProductById(int id)
        {
            _productCol.Remove(_productCol.Find(x => x.ProductId == id));
        }

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
