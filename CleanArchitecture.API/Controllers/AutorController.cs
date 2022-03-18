using CleanArcuitecture.Application.Feactures.Autores.Commands;
using CleanArcuitecture.Application.Feactures.Autores.Commands.DeleteAutor;
using CleanArcuitecture.Application.Feactures.Autores.Commands.UpdateAutor;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CleanArchitecture.API.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class AutorController: ControllerBase
    {
        private readonly IMediator _mediator;

        public AutorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateAutor")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateAutor([FromBody] CreateAutorCommand createAutorCommand)
        {
          return await _mediator.Send(createAutorCommand);
        }

        [HttpPut( Name = "UpdateAutor")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateAutor([FromBody] UpdateAutorCommand updateAutorCommand)
        {
            await _mediator.Send(updateAutorCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteAutor")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteAutor(int id)
        {
            var command = new DeleteAutorCommand
            {
                Id = id
            };

           await _mediator.Send(command);

            return NoContent();
        }
    }
}
