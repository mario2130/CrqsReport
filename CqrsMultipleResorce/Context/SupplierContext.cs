using CqrsMultipleResorce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsMultipleResorce.Context
{
    public class SupplierContext : ISupplier
    {
        public Task<IEnumerable<Supplier>> GetSuppliers(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
