using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarPlace_Backend.Controllers.Repository;
using CarPlace_Backend.Models;
using CarPlace_Backend.Models.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarPlace_Backend.Controllers
{
    [Route("api/[controller]")]
    public class UserLoginValidation : Controller
    {
        readonly IUser<ZoomCarUser> _repo;
        // GET: api/<controller>
        [HttpGet("{email,Pass}")]
        public Boolean Get(String email,String pass)
        {
            return _repo.Valid(email,pass) ;
        }

      
    }
}
