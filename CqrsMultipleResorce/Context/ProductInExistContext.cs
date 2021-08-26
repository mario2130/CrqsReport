using CqrsMultipleResorce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsMultipleResorce.Context
{
    public class ProductInExistContext : IProductInExistContext
    {
        public async Task<IEnumerable<ProductInExist>> GetProductInExists()
        {
            throw new NotImplementedException();
        }
    }
}
