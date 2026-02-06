using eCommerce.Core.DTO;
using eCommerce.Core.ServiceContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public AuthController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<IActionResult> Register(RegisterRequest? registerRequest)
        {
            if (registerRequest == null)
                return BadRequest("Invalid Registration Data");

            AuthenticationResponse? user = await _usersService.Register(registerRequest);

            if(user == null || user.Success == false)
                return NotFound(user);

            return Ok(user);
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest? loginRequest)
        {
            if (loginRequest == null)
                return BadRequest("Invalid Request");

            AuthenticationResponse? user = await _usersService.Login(loginRequest);

            if( user == null || user.Success == false ) 
                return Unauthorized(user);

            return Ok(user);
        }
    }
}
