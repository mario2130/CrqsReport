using CqrsMultipleResorce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsMultipleResorce.Context
{
    public interface IProductContext
    {
        Task<int> Add(Product product);
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
    }
}
