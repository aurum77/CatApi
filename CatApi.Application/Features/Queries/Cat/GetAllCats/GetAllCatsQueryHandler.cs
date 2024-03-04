using CatApi.Application.Services;
using MediatR;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatApi.Application.Features.Queries.Cat.GetAllCats
{
    public class GetAllCatsQueryHandler : IRequestHandler<GetAllCatsQueryRequest, GetAllCatsQueryResponse>
    {
        private readonly ICatService _catService;

        public GetAllCatsQueryHandler(ICatService catService)
        {
            _catService = catService;
        }

        public async Task<GetAllCatsQueryResponse> Handle(GetAllCatsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = _catService.GetCats();
            int totalDataCount = data.Count();

            Console.WriteLine("WE DO A LITTLE TROLLING");
            return new()
            {
                Cats = data,
                TotalCatCount = totalDataCount
            };
        }
    }
}
