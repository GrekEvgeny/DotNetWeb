using System;
using System.Collections.Generic;
using System.Linq;
using ProductsCore.Models;

namespace ProductsDataLayer
{
    public class ProductsRepository
    {
        private static List<Product> _products;

        static ProductsRepository()
        {
            _products = new List<Product>();
        }

        public Guid Create(Product product)
        {
            product.Id = Guid.NewGuid();

            _products.Add(product);

            return product.Id;
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(Guid Id)
        {
            return _products.FirstOrDefault(x => x.Id == Id);
        }

        public Product Update(Product product)
        {
            Product oldProduct = _products.FirstOrDefault(x => x.Id == product.Id);

            if (oldProduct != null)
            {
                var index = _products.IndexOf(oldProduct);
                product.IsAvailableToBuy = oldProduct.IsAvailableToBuy;
                _products[index] = product;

                return product;
            }

            return null;
        }

        public Product DeleteById(Guid id)
        {
            Product oldProduct = _products.FirstOrDefault(x => x.Id == id);
            _products.Remove(oldProduct);

            return oldProduct;
        }
    }
}
