using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarPlace_Backend.Controllers.Repository;
using Microsoft.AspNetCore.Mvc;

using CarPlace_Backend.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarPlace_Backend.Controllers
{
    [Produces("application/json")]
    [Route("api/CarPlace")]
    public class CarPlaceController : Controller
    {
        readonly CarDetailsInterface<CarDetails> _repo;
      public  CarPlaceController(CarDetailsInterface<CarDetails> context1)
        {
            this._repo = context1;
        }
        [HttpGet("{CarId}")]
        public IEnumerable<Models.CarDetails> Get([FromRoute] int CarId)
          {
            return _repo.readbyId(CarId);
           }
        [HttpGet]
        public List<CarDetails> read()
        {

            return (_repo.read());
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Object obj)
        {
            _repo.updatestatus(id);
        }
    }
}

