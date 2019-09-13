using myStore.Models;
using System.Collections.Generic;
using System.Linq;


namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Shirts", Price = 15 },
            new Product { Name = "Shoes", Price = 75 },
            new Product { Name = "Purses", Price = 50 }
        }.AsQueryable<Product>();
    }
}