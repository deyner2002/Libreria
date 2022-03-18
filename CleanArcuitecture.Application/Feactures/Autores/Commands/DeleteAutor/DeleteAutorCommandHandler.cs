using AutoMapper;
using CleanArchitecture.Domain;
using CleanArcuitecture.Application.Contracts.Persistence;
using CleanArcuitecture.Application.Exceptions;
using MediatR;
using Microsoft.Extensions.Logging;


namespace CleanArcuitecture.Application.Feactures.Autores.Commands.DeleteAutor
{
    public class DeleteAutorCommandHandler : IRequestHandler<DeleteAutorCommand>
    {
        private readonly IAutorRepository _autorRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<DeleteAutorCommandHandler> _logger;

        public DeleteAutorCommandHandler(IAutorRepository autorRepository, IMapper mapper, ILogger<DeleteAutorCommandHandler> logger)
        {
            _autorRepository = autorRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(DeleteAutorCommand request, CancellationToken cancellationToken)
        {
           var autorToDelete = await _autorRepository.GetByIdAsync(request.Id);
            if(autorToDelete == null)
            {
                _logger.LogError($"{request.Id} no existe en el sistema");
                throw new NotFoundException(nameof(Autor), request.Id);
            }
            await _autorRepository.DeleteAsync(autorToDelete);
            _logger.LogInformation($"{request.Id} fue eliminado con exito");
            return Unit.Value;
        }
    }
}
