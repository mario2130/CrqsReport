using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsMultipleResorce.Model
{
    public class ProductInExist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdCategory { get; set; }
        public int IdSupplier { get; set; }
        public string DescripcionCategory { get; set; }
        public string NameSupplier { get; set; }
    }
}
