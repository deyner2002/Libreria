using MediatR;

namespace CleanArcuitecture.Application.Feactures.Libros.Queries.GetLibrosList
{
    public class GetLibrosListQuery: IRequest<List<LibrosVm>>
    {
        public string UserName { get; set; }= String.Empty; 

        public GetLibrosListQuery(string userName)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        }
    }
}
