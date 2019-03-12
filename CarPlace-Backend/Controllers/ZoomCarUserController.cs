using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarPlace_Backend.Models;
using CarPlace_Backend.Models.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarPlace_Backend.Controllers
{
    [Produces("application/json")]
    [Route("api/ZoomCarUser")]
    public class ZoomCarUserController : Controller
    {
        readonly IUser<ZoomCarUser> _repository;
        public ZoomCarUserController(IUser<ZoomCarUser> z_repository) {
            this._repository = z_repository;
        }
        [HttpGet]
        public List<ZoomCarUser> Get()
        {

            return _repository.read();
        }
        [HttpGet("{Email}")]
        public IActionResult Get([FromRoute] String Email)
        {
             
            // return _repository.ZoomCarUser.Where(q => q.Email ==Email);
            return Ok(_repository.readByEmail(Email));
        }


        [HttpPost]
        public IActionResult Post([FromBody]Models.ZoomCarUser user)
           {
            if (user == null)
            {
                return BadRequest("ZoomCarUser is null.");
            }
            _repository.create(user);
            return CreatedAtRoute(
                  "Get",
                  new { ZoomCarUserId = user.UserId },
                                user);

          }
        // PUT: api/ZoomCarUser/5
        [HttpPut("{email}")]
        public IActionResult Put( [FromRoute] String email, [FromBody] ZoomCarUser user)
        {
            if (user == null)
            {
                return BadRequest("ZoomCarUser is null.");
            }
            else {
                _repository.update(user);
            }
            return Ok("Updated");
        }


    }
}
