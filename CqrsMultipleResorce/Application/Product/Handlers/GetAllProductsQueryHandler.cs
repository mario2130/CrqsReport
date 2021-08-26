using CqrsMultipleResorce.Application.Product.Queries;
using CqrsMultipleResorce.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CqrsMultipleResorce.Model;

namespace CqrsMultipleResorce.Application.Product.Handlers
{
    public class GetAllProductsQueryHandler : 
        IRequestHandler<GetAllProductsQuery, IEnumerable<Model.Product>>
    {

        readonly IProductContext _context;
        public GetAllProductsQueryHandler(IProductContext context) => _context = context;

        public async Task<IEnumerable<Model.Product>> Handle(GetAllProductsQuery query,
            CancellationToken cancellationToken)
        {
            return await _context.GetProducts();
        }
    }
}
