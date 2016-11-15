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

        public IList<Product> GetProducts()
        {
            return _productCol;
        }

        public Product GetProductById(int id)
        {
            return _productCol.Find(x => x.ProductId == id);
        } 

       

        public void DeleteProductById(int id)
        {
            _productCol.Remove(_productCol.Find(x => x.ProductId == id));
        }

        public void UpdateProduct(Product p)
        {
            //productCol.Find(x => x.ProductId == p.ProductId).Price = p.Price;
            //_productCol.Find(x => x.ProductId == p.ProductId).Description = p.Description;
            int i = _productCol.FindIndex(x => x.ProductId == p.ProductId);
            _productCol[i] = p;
        }
   }
}
