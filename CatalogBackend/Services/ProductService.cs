using CatalogBackend.Data.Models;
using CatalogBackend.Services;
using System.Collections.Generic;


namespace CatalogBackend.Data
{
    public class ProductService
    {
        private readonly ProductRepository productRepository;

        public ProductService(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void Create(ProductModel newProduct)
        {
            if (Read(newProduct.name) == null)
            {
                productRepository.Insert(newProduct);
            }
        }

        public List<ProductModel> Read()
        {
            return productRepository.GetAll();
        }

        public ProductModel Read(string name)
        {
            return productRepository.GetOne(name);
        }
    }
}
