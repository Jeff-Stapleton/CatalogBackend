using System.Collections.Generic;
using System.Linq;
using CatalogBackend.Data.Models;

namespace CatalogBackend.Data.Repositories
{
    public class ProductRepository
    {
        private List<ProductModel> Products = new List<ProductModel>();

        public ProductRepository()
        {

        }

        public List<ProductModel> GetAll()
        {
            return Products;
        }

        public ProductModel GetOne(string name)
        {
            return Products.FirstOrDefault(p => p.name == name);
        }

        public void Insert(ProductModel newProduct)
        {
            Products.Add(newProduct);
        }
    }
}
