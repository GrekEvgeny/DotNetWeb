using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsCore.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public bool IsAvailableToBuy { get; set; }
    }
}
