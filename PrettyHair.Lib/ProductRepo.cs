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
        
        private List<Product> _productCol;
        #endregion

        public ProductRepo()
        {
            _productCol = new List<Product>();
        }

        #region Methods

        public void AddProduct(IProduct ip)
        {
            _productCol.Add(new Product(ip.ProductId, ip.Price, ip.Description));
        }
        public IList<Product> GetProducts()
        {
            return _productCol;
        }

        public Product GetProductById(int id)
        {
            return _productCol.Find(x => x.ProductId == id);
        } 
               

        public void UpdateProduct(IProduct p)
        {
            Product mutablep = _productCol.Find(x => x.ProductId == p.ProductId);
            mutablep.Price = p.Price;
            mutablep.Description = p.Description;
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
