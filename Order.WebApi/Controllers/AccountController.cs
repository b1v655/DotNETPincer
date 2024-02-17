
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Order.Persistence;
using Order.Persistence.DTO;

namespace Cinema.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Account")]
    public class AccountController : Controller
    {
        private readonly SignInManager<Employee> _signInManager;

        public AccountController(SignInManager<Employee> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromBody] LoginDTO user)
        {

            if (_signInManager.IsSignedIn(User))
                await _signInManager.SignOutAsync();

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(user.UserName, user.Password, isPersistent: false,
                   lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return Ok();
                }

                ModelState.AddModelError("", "Bejelentkezés sikertelen!");
                return Unauthorized();
            }
            return Unauthorized();
        }

        [HttpPost("Signout")]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return Ok();
        }
    }
}

