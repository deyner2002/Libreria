using CleanArchitecture.Domain;
using CleanArchitecture.Infrastructure.Persistence;
using CleanArcuitecture.Application.Contracts.Persistence;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class AutorRepository: RepositoryBase<Autor>, IAutorRepository
    {
        public AutorRepository(ApplicationDbContext context): base(context)
        {

        }
    }
}
