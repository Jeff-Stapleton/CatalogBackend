using CatalogBackend.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace CatalogBackend.Services
{
    public class ProductRepository
    {
        List<ProductModel> Products = new List<ProductModel>
        {
            new ProductModel{name="Product 1", description="This is a description of product number 1", quantity=1},
            new ProductModel{name="Product 2", description="This is a description of product number 2", quantity=2},
            new ProductModel{name="Product 3", description="This is a description of product number 3", quantity=3},
            new ProductModel{name="Product 4", description="This is a description of product number 4", quantity=4},
            new ProductModel{name="Product 5", description="This is a description of product number 5", quantity=5},
            new ProductModel{name="Product 6", description="This is a description of product number 6", quantity=6},
            new ProductModel{name="Product 7", description="This is a description of product number 7", quantity=7},
            new ProductModel{name="Product 8", description="This is a description of product number 8", quantity=8},
            new ProductModel{name="Product 9", description="This is a description of product number 9", quantity=9},
            new ProductModel{name="Product 10", description="This is a description of product number 10", quantity=10},
            new ProductModel{name="Product 11", description="This is a description of product number 11", quantity=11},
            new ProductModel{name="Product 12", description="This is a description of product number 12", quantity=12},
            new ProductModel{name="Product 13", description="This is a description of product number 13", quantity=13},
            new ProductModel{name="Product 14", description="This is a description of product number 14", quantity=14},
            new ProductModel{name="Product 15", description="This is a description of product number 15", quantity=15},
            new ProductModel{name="Product 16", description="This is a description of product number 16", quantity=16},
            new ProductModel{name="Product 17", description="This is a description of product number 17", quantity=17},
            new ProductModel{name="Product 18", description="This is a description of product number 18", quantity=18},
            new ProductModel{name="Product 19", description="This is a description of product number 19", quantity=19},
            new ProductModel{name="Product 20", description="This is a description of product number 20", quantity=20},
        };

        public ProductRepository()
        {

        }

        public List<ProductModel> GetAll()
        {
            return Products;
        }

        public ProductModel GetOne(string name)
        {
            return Products.Where(p => p.name == name).FirstOrDefault();
        }

        public void Insert(ProductModel newProduct)
        {
            Products.Add(newProduct);
        }
    }
}
