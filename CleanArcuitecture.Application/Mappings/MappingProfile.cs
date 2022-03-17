using CleanArchitecture.Domain;
using CleanArcuitecture.Application.Feactures.Libros.Queries.GetLibrosList;
using AutoMapper;

namespace CleanArcuitecture.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Libro, LibrosVm>();
        }
    }
}
