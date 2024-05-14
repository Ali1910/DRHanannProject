using DRHanannProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DRHanannProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _Repo;
        public UserController(IUserRepo repp)
        {

            _Repo = repp;

        }
        [HttpPost]
        public IActionResult Post([FromQuery] string email, string password)

        {

            bool checker = _Repo.createuser(email, password);
            if (checker)
            {
                return Ok("Email created");
            }
            else
            {
                return BadRequest("try again maybe with different email");
            }
        }
        [HttpGet]
        public IActionResult Get([FromQuery ]string email,string password)
        {
            user User=_Repo.GetUser(email, password);
            if (User==null)
            {
                return BadRequest("Wrong Email or Password try again");
            }
            else
            {
                return Ok(User);
            }
        }

    }
}
