using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarPlace_Backend.Models.Repository;
using CarPlace_Backend.Models.DataController;
using Microsoft.AspNetCore.Mvc;
using CarPlace_Backend.Controllers.Repository;
using CarPlace_Backend.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarPlace_Backend.Controllers
{
    [Produces("application/json")]
    [Route("api/Order")]
    public class OrderController : Controller
    {
        readonly Repository<Models.OrderDetails> _repository;
        public OrderController(Repository<Models.OrderDetails> opt1) {
            _repository = opt1;
        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok( _repository.read());
        
            }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.readById(id));
        }

        // POST api/<controller>
        // POST: api/Order1
        [HttpPost]
        public IActionResult Post([FromBody] OrderDetails Order1)
        {
            if (Order1 == null)
            {
                return BadRequest("OrderDetails is null.");
            }

            _repository.create( Order1);
            return CreatedAtRoute(
                  "Get",
                  new { Id = Order1.OrderId },
                                               Order1);
        }

        // PUT api/<controller>/5
        // PUT: api/Order1/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] OrderDetails Order1)
        {
            if (Order1 == null)
            {
                return BadRequest("Order1 is null.");
            }

             OrderDetails Order1ToUpdate = _repository.readById(id);
            if (Order1ToUpdate == null)
            {
                return NotFound("The Order1 record couldn't be found."+Order1ToUpdate);
            }

            _repository.update( Order1);
            return NoContent();
        }


        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
