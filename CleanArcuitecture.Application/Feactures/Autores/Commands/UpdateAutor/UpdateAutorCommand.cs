using MediatR;

namespace CleanArcuitecture.Application.Feactures.Autores.Commands.UpdateAutor
{
    public class UpdateAutorCommand: IRequest
    {
        public int Id { get; set; }
        public string Nombre { get; set; }= string.Empty;
    }
}
