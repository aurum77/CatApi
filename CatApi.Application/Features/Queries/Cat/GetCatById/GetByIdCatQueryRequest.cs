using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatApi.Application.Features.Queries.Cat.GetCatById
{
    public class GetByIdCatQueryRequest : IRequest<GetByIdCatQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
