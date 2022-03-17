using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain
{
    public class AutorLibro: BaseDomainModel
    {
        public int LibroId { get; set; }
        public int AutorId { get; set; }
        public int Orden { get; set; }
        public Libro Libro { get; set; }
        public Autor Autor { get; set; }
    }
}
