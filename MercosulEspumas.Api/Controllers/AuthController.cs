using MercosulEspumas.Api.Models;
using MercosulEspumas.Api.Repositories;
using MercosulEspumas.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MercosulEspumas.Api.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        [Route("auth")]
        public ActionResult<dynamic> Authenticate([FromBody] TokenForUserModel model)
        {
            var user = UserRepository.Get(model.Username, model.Password);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha Inválidos" });

            var token = TokenService.GenerateToken(user);

            //return Ok(token);

            return new
            {
                token = token,
            };
        }

        [HttpGet]
        [Route("authenticated")]
        [Authorize(Roles = "TI")]
        public string Authenticated() => $"Autencidade - {User.Identity?.Name}";
    }
}
