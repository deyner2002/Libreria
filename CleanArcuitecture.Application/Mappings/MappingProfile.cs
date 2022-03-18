using CleanArchitecture.Domain;
using CleanArcuitecture.Application.Feactures.Libros.Queries.GetLibrosList;
using AutoMapper;
using CleanArcuitecture.Application.Feactures.Autores.Commands;

namespace CleanArcuitecture.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Libro, LibrosVm>();
            CreateMap<CreateAutorCommand, Autor>();
        }
    }
}
