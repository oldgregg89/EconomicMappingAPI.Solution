using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EconomicMappingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EconomicMappingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EconomicMappingAPIController : ControllerBase
    {
        private EconomicMappingAPIContext _db;

        public EconomicMappingAPIController(EconomicMappingAPIContext db)
        {
        _db = db;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<State>> Get()
        {
            return _db.States.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<State> Get(int id)
        {
            
            return _db.States.FirstOrDefault(entry => entry.StateId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] State value)
        {
            _db.States.Add(value);
            _db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] State value)
        {
            value.StateId = id;
            _db.Entry(value).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var stateToDelete = _db.States.FirstOrDefault(entry => entry.StateId == id);
            _db.States.Remove(stateToDelete);
            _db.SaveChanges();
        }
    }
}
