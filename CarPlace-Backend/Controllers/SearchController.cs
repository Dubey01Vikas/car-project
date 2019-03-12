using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarPlace_Backend.Controllers.Repository;
using CarPlace_Backend.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarPlace_Backend.Controllers
{
    [Produces("application/json")]
    [Route("api/Search")]
    public class SearchController : Controller
    {
        readonly CarDetailsInterface<CarDetails> _repo;
        public SearchController(CarDetailsInterface<CarDetails> repo) {
            this._repo = repo;
        }
        [HttpGet("{CompanyName}")]
        public IActionResult Get([FromRoute] String CompanyName)
        {
            return Ok(_repo.searchByName(CompanyName));
        }


    }
}
