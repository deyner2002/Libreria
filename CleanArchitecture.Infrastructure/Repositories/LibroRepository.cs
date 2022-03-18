using CleanArchitecture.Domain;
using CleanArchitecture.Infrastructure.Persistence;
using CleanArcuitecture.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class LibroRepository : RepositoryBase<Libro>, ILibroRepository
    {
        public LibroRepository(ApplicationDbContext context): base(context)
        {

        }

        public async Task<Libro> GetLibroByNombre(string nombreLibro)
        {
            return await _context.Libros.Where(o => o.Titulo == nombreLibro).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Libro>> GetLibroByUserName(string userName)
        {
            return await _context.Libros.Where(v => v.CreatedBy == userName).ToArrayAsync();
        }
    }
}
