using CatApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatApi.Application.Features.Queries.Cat.GetCatById
{
    public class GetByIdCatQueryHandler : IRequestHandler<GetByIdCatQueryRequest, GetByIdCatQueryResponse>
    {
        private readonly ICatReadRepository _catReadRepository;

        public GetByIdCatQueryHandler(ICatReadRepository catReadRepository)
        {
            _catReadRepository = catReadRepository;
        }

        public async Task<GetByIdCatQueryResponse> Handle(GetByIdCatQueryRequest request, CancellationToken cancellationToken)
        {
            var cat = await _catReadRepository.GetByIdAsync(request.Id.ToString(), false);

            return new()
            {
                Cat = cat
            };
        }
    }
}
