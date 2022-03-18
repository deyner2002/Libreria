using MediatR;

namespace CleanArcuitecture.Application.Feactures.Autores.Commands
{
    public class CreateAutorCommand: IRequest<int>
    {
        public string Nombre { get; set; }= String.Empty;

    }
}
