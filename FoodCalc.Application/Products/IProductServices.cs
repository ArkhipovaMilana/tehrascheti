using FoodCalc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCalc.Application.Products
{
    public interface IProductService
    {
        void AddProduct(Product product);
        List<Product> GetProducts();
    }
}
