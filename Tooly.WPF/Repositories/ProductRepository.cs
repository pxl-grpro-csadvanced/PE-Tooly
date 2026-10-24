using System;
using System.Collections.Generic;
using System.Text;
using Tooly.WPF.Models;

namespace Tooly.WPF.Repositories
{
    internal class ProductRepository
    {
        private readonly List<Product> _products = new List<Product>();

        public ProductRepository()
        {
            //Initialize _products with 10 sample products 
            _products = new List<Product>()
            {
                new Product { Id = 1, Name = "Accuschroefboormachine 20V", Category = "Elektrisch" },
                new Product { Id = 2, Name = "Multitool oscillerend", Category = "Elektrisch" },
                new Product { Id = 3, Name = "Haakse slijper 125 mm", Category = "Elektrisch" },
                new Product { Id = 4, Name = "Set steeksleutels 8-delig", Category = "Handgereedschap" },
                new Product { Id = 5, Name = "Klauwhamer glasvezel", Category = "Handgereedschap" },
                new Product { Id = 6, Name = "Snoeischaar professioneel", Category = "Tuin" },
                new Product { Id = 7, Name = "Tuinhark met essenhouten steel", Category = "Tuin" },
                new Product { Id = 8, Name = "Spade RVS", Category = "Tuin" },
                new Product { Id = 9, Name = "Huishoudtrap 4 treden", Category = "Ladders" },
                new Product { Id = 10, Name = "Uitschuifbare ladder 3,2 m", Category = "Ladders" },
            };

        }

        public List<Product> GetAll()
        {
            return _products.ToList();
        }

        public void Add(Product product)
        {
            product.Id = _products.Count + 1;
            _products.Add(product);
        }


    }
}
