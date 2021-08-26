using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsMultipleResorce.Application.Report.Queries
{
    public class GetProductInExistQuery : IRequest<IEnumerable<Model.ProductInExist>>
    {
    }
}
