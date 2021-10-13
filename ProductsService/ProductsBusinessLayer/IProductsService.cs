using System;
using ProductsBusinessLayer.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProductsCore.Models;

namespace ProductsBusinessLayer
{
    public interface IProductsService
    {
        Task<Guid> CreateProduct(ProductDTO productDTO);
        Task<Product> DeleteProductById(Guid id);
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(Guid id);
        Task<Product> UpdateProduct(Guid id, ProductDTO productDTO);
    }
}