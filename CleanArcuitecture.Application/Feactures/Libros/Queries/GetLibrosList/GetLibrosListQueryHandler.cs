
using AutoMapper;
using CleanArcuitecture.Application.Contracts.Persistence;
using MediatR;


namespace CleanArcuitecture.Application.Feactures.Libros.Queries.GetLibrosList
{
    public class GetLibrosListQueryHandler : IRequestHandler<GetLibrosListQuery, List<LibrosVm>>
    {
        private readonly ILibroRepository _libroRepository;
        private readonly IMapper _mapper;

        public GetLibrosListQueryHandler(ILibroRepository libroRepository, IMapper mapper)
        {
            _libroRepository = libroRepository;
            _mapper = mapper;
        }

        public async Task<List<LibrosVm>> Handle(GetLibrosListQuery request, CancellationToken cancellationToken)
        {
            var libroList = await  _libroRepository.GetLibroByUserName(request.UserName);
            return _mapper.Map<List<LibrosVm>>(libroList);
        }
    }
}
