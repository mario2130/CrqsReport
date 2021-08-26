using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CqrsMultipleResorce.Model;

namespace CqrsMultipleResorce.Application.Product.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Model.Product>>
    { 

    }
}
