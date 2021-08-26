using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsMultipleResorce.Context
{
    public interface IProductInExistContext
    {
        Task<IEnumerable<Model.ProductInExist>> GetProductInExists();
    }
}
