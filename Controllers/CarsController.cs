using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gregslist.Models;
using gregslist.Services;

namespace gregslist.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly CarsService _cs;

        public CarsController(CarsService cs)
        {
            _cs = cs;
        }
        [HttpGet]
        public ActionResult<List<Car>> Get()
        {
            try
            {
                List<Car> cars = _cs.Get();
                return Ok(cars);
            }
            catch (System.Exception)
            {
                return BadRequest("Could not get");
            }
        }
        [HttpGet("{id}")]
        public ActionResult<Car> Get(string id)
        {
            try
            {
                Car car = _cs.Get(id);
                return Ok(car);
            }
            catch (System.Exception)
            {
                return BadRequest("Couldn't get that car");
            }
        }
        [HttpPost]
        public ActionResult<Car> Create([FromBody] Car carData)
        {
            try
            {
                Car newCar = _cs.Create(carData);
                return Ok(newCar);
            }
            catch (System.Exception)
            {
                return BadRequest("Failed to post car");
            }
        }
        [HttpPut("{id}")]
        public ActionResult<Car> Edit(string id, [FromBody] Car carData)
        {
            try
            {
                carData.Id = id;
                Car updated = _cs.Edit(carData);
                return Ok(updated);
            }
            catch (System.Exception)
            {
                return BadRequest("could not edit");
            }
        }
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(string id)
        {
            try
            {
                _cs.Delete(id);
                return Ok("Disposed of...");
            }
            catch (System.Exception)
            {
                return BadRequest("Could not destroy car");
            }
        }
    }
}