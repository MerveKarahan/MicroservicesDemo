using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Identity.Dtos;
using Services.Identity.Models;
using System.Threading.Tasks;

namespace Services.Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult>SingUp(SingUpDto singUpDto)
        {
            var user = new ApplicationUser
            {
                UserName = singUpDto.UserName,
                Email = singUpDto.Email,
                City = singUpDto.City,
            };
            var result = await _userManager.CreateAsync(user,singUpDto.Password);
            if (!result.Succeeded)
            {
                return BadRequest();

            }
            return Ok() ;
        }
    }
}
