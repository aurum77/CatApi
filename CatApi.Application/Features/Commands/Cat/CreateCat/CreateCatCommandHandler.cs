using CatApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatApi.Application.Features.Commands.Cat.CreateCat
{
    public class CreateCatCommandHandler : IRequestHandler<CreateCatCommandRequest, CreateCatCommandResponse>
    {
        private readonly ICatWriteRepository _catWriteRepository;

        public CreateCatCommandHandler(ICatWriteRepository catWriteRepository)
        {
            _catWriteRepository = catWriteRepository;
        }

        public async Task<CreateCatCommandResponse> Handle(CreateCatCommandRequest request, CancellationToken cancellationToken)
        {
            var status = await _catWriteRepository.AddAsync(new()
            {
                Name = request.Name,
                Color = request.Color,
                ImageUrl = request.ImageUrl
            });

            await _catWriteRepository.SaveAsync();

            return new()
            {
                Status = status
            };
        }
    }
}
