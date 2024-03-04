using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatApi.Application.Features.Commands.Cat.CreateCat
{
    public class CreateCatCommandRequest : IRequest<CreateCatCommandResponse>
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string ImageUrl { get; set; }
    }
}
