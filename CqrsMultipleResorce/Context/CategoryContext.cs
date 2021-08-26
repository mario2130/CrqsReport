using CqrsMultipleResorce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsMultipleResorce.Context
{
    public class CategoryContext : ICategory
    {
        public Task<Category> GetCategory(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
