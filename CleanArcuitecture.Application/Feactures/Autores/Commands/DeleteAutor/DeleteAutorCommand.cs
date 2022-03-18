using MediatR;

namespace CleanArcuitecture.Application.Feactures.Autores.Commands.DeleteAutor
{
    public class DeleteAutorCommand: IRequest
    {
        public int Id { get; set; }
    }
}
