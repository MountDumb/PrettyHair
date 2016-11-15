using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using PrettyHair.Lib;

namespace PrettyHair.Test
{
    [TestFixture]
    public class ProductRepoTest
    {
        ProductRepo prepo;
        public ProductRepoTest()
        {
            prepo = new ProductRepo();
            prepo.AddProduct(new Product(0, 2.45m, "Tusk"));
            prepo.AddProduct(new Product(1, 3.89m, "Pen"));
            prepo.AddProduct(new Product(2, 9.67m, "Thermostat"));
        }

        [Test]
        public void ProductRepoCanAddNewProducts()
        {
            Product p; 
            p = new Product(4, 56.7m, "SuperGold");
            prepo.AddProduct(p);

            Assert.AreEqual(4, prepo.GetProducts().Count);

        }

        
    }
}
