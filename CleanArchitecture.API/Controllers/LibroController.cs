using CleanArcuitecture.Application.Feactures.Libros.Queries.GetLibrosList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CleanArchitecture.API.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class LibroController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LibroController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("{userName}", Name = "GetLibro")]
        [ProducesResponseType(typeof(IEnumerable<LibrosVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<LibrosVm>>> GetLibrosByUserName(string username)
        {
            var query = new GetLibrosListQuery(username);
            var libros = await _mediator.Send(query);
            return Ok(libros);
        }

    }
}
