using CleanArchitecture.Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Domain
{
    public class Comentario: BaseDomainModel
    {
        public string Contenido { get; set; }
        public int LibroId { get; set; }
        public Libro Libro { get; set; }
        public string UsuarioId { get; set; }
        public IdentityUser Usuario { get; set; }
    }
}
