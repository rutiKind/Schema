using Dal;
using Dal.Service;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace BravermanB.Controllers
{
   
    [ApiController]
        [Route("api/Users")]
        public class UserController : ControllerBase
        {

            private readonly userService _UserService;

            public UserController(userService UserService)
            {
                _UserService = UserService;
            }

            [HttpPost]
            public IActionResult AddUser([FromBody] User User)
            {
                _UserService.Adduser(User);
                return Ok("User added successfully");
            }

            [HttpGet("{name}")]
            public IActionResult GetUserByName(string firstName)
            {
                var User = _UserService.GetUserByfirstName(firstName);

                if (User == null)
                {
                    return NotFound();
                }

                return Ok(User);
            }
        }

    }

