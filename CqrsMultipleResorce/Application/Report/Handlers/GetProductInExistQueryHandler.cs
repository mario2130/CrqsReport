using CqrsMultipleResorce.Application.Report.Queries;
using CqrsMultipleResorce.Context;
using CqrsMultipleResorce.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CqrsMultipleResorce.Application.Report.Handlers
{
    public class GetProductInExistQueryHandler :
        IRequestHandler<GetProductInExistQuery, IEnumerable<Model.ProductInExist>>
    {

        readonly IProductInExistContext _productInExistContext;

        public GetProductInExistQueryHandler(IProductInExistContext productInExistContext)
            => _productInExistContext = productInExistContext;



        public Task<IEnumerable<ProductInExist>> Handle(GetProductInExistQuery query, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
