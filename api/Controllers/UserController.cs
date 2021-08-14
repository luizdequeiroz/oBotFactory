using Microsoft.AspNetCore.Mvc;
using service.IServiceCluster;
using System;
using System.Threading.Tasks;
using static api.Controllers.Treatments.Returns;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("{username}")]
        public async Task<IActionResult> ReadUserByUsernameAsync(string username)
        {
            try
            {
                var user = await userService.GetUserByUsernameAsync(username);

                return Success(user);
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }
    }
}
