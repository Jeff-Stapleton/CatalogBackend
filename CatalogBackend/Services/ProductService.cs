using System.Collections.Generic;
using CatalogBackend.Data.Models;
using CatalogBackend.Data.Repositories;
using CatalogBackend.Exceptions;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CatalogBackend.Services
{
    public class ProductService
    {
        private readonly ProductRepository productRepository;

        public ProductService(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void Create(ModelStateDictionary modelState, ProductModel newProduct)
        {
            if (modelState.IsValid && Read(newProduct.name) != null)
            {
                modelState.AddModelError(nameof(ProductModel.name), "Product name must be unique");
            }

            if (modelState.IsValid == false)
            {
                throw new ValidationFailureException(modelState);
            }

            productRepository.Insert(newProduct);
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
