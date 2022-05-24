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
    public class HousesController : ControllerBase
    {
        private readonly HousesService _hs;

        public HousesController(HousesService hs)
        {
            _hs = hs;
        }
        [HttpGet]
        public ActionResult<List<House>> Get()
        {
            try
            {
                List<House> houses = _hs.Get();
                return Ok(houses);
            }
            catch (System.Exception)
            {
                return BadRequest("Could not fetch houses");
            }
        }
        [HttpGet("{id}")]
        public ActionResult<List<House>> Get(string id)
        {
            try
            {
                House houses = _hs.Get(id);
                return Ok(houses);
            }
            catch (System.Exception)
            {
                return BadRequest("Could not fetch houses");
            }
        }
        [HttpPost]
        public ActionResult<House> Create([FromBody] House houseData)
        {
            try
            {
                House newHouse = _hs.Create(houseData);
                return Ok(newHouse);
            }
            catch (System.Exception)
            {
                return BadRequest("Could not create house");
            }
        }
        [HttpPut("{id}")]
        public ActionResult<House> Edit(string id, [FromBody] House houseData)
        {
            try
            {
                houseData.Id = id;
                House updated = _hs.Edit(houseData);
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
                _hs.Delete(id);
                return Ok("found house from services");
            }
            catch (System.Exception)
            {
                return BadRequest("Could not destroy house");
            }
        }

    }
}