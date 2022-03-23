using CleanArcuitecture.Application.Contracts.Identity;
using CleanArcuitecture.Application.Models.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [ApiController]
    [Route("api/v1/account")]
    public class AccountController: ControllerBase
    {
        private readonly IAuthService authService;

        public AccountController(IAuthService authService)
        {
            this.authService = authService;
        }
       
        [HttpPost("login", Name = "Login")]
        public async Task<ActionResult<AuthResponse>> Login([FromBody] AuthRequest auth)
        {
            return Ok(await authService.Login(auth));
        }

        
        [HttpPost("register", Name = "Register")]
        public async Task<ActionResult<RegistrationResponse>> Register([FromBody] RegistrationRequest regis)
        {
            return Ok(await authService.Register(regis));
        }
    }
}
