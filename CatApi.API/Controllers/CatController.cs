using CatApi.Application.Features.Queries.Cat.GetAllCats;
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
        public async Task<IActionResult> Add()
        {
            var query = await _catWriteRepository.AddAsync(new()
            {
                Id = Guid.NewGuid(),
                Name = "Hamza",
                Color = "Tekir",
            });

            await _catWriteRepository.SaveAsync();

            return Ok(query);
        }
        [HttpGet(Name = "GetCat")]
        public async Task<IActionResult> GetAsync([FromQuery] GetAllCatsQueryRequest getAllCatsQueryRequest)
        {
            GetAllCatsQueryResponse response = await _mediator.Send(getAllCatsQueryRequest);
            return Ok(response);
        }
    }
}
