using Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequestDto RegisterModel)
        {
            return Ok();
        }

    }
}
