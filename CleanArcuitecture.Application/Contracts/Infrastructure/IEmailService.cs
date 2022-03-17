using CleanArcuitecture.Application.Models;

namespace CleanArcuitecture.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
