using CatApi.Application.Features.Commands.Cat.CreateCat;
using CatApi.Application.Features.Queries.Cat.GetAllCats;
using CatApi.Application.Features.Queries.Cat.GetCatById;
using CatApi.Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// docker run --name cat-postgres -e POSTGRES_PASSWORD='Vr97_6gb.oMA' -e POSTGRES_DB='cat' -p 5432:5432 postgres:alpine
namespace CatApi.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CatController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ICatWriteRepository _catWriteRepository;

        public CatController(IMediator mediator, ICatWriteRepository catWriteRepository)
        {
            _mediator = mediator;
            _catWriteRepository = catWriteRepository;
        }

        [HttpGet(Name = "AddCat")]
        public async Task<IActionResult> AddCatAsync([FromQuery] CreateCatCommandRequest createCatCommandRequest)
        {
            CreateCatCommandResponse response = await _mediator.Send(createCatCommandRequest);

            return Ok(response);
        }

        [HttpGet(Name = "GetCat")]
        public async Task<IActionResult> GetAsync([FromQuery] GetAllCatsQueryRequest getAllCatsQueryRequest)
        {
            GetAllCatsQueryResponse response = await _mediator.Send(getAllCatsQueryRequest);
            return Ok(response);
        }

        [HttpGet(Name = "GetCatById")]
        public async Task<IActionResult> GetByIdAsync([FromQuery] GetByIdCatQueryRequest getByIdCatQueryRequest)
        {
            GetByIdCatQueryResponse response = await _mediator.Send(getByIdCatQueryRequest);
            return Ok(response);
        }
    }
}
