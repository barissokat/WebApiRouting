using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiRouting.Models;

namespace WebApiRouting.Controllers
{
    public class ProductApiController : ApiController
    {
        private List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Desktop PC", Price = 4300},
            new Product { Id = 2, Name = "Laptop PC", Price = 3600},
            new Product { Id = 3, Name = "All in One PC", Price = 5200},
            new Product { Id = 4, Name = "LED TV", Price = 1600},
            new Product { Id = 5, Name = "LCD TV", Price = 1000},
            new Product { Id = 6, Name = "Smart TV", Price = 2200}
        };

        [HttpGet]
        public IEnumerable<Product> AllProducts()
        {
            return _products;
        }
    }
}
