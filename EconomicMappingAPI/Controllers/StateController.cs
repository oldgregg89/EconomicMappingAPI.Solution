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
    public class StateController : ControllerBase
    {
        private EconomicMappingAPIContext _db;

        public StateController(EconomicMappingAPIContext db)
        {
            _db = db;
        }
        // GET api/values
        [HttpGet("states")]
        public ActionResult<IEnumerable<State>> Get(string name, int gdp, string mainExport, string mainImport)
        {
            var query = _db.States.AsQueryable();
            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }
            if (mainExport != null)
            {
                query = query.Where(entry => entry.MainExport == mainExport);
            }
            if (mainImport != null)
            {
                query = query.Where(entry => entry.MainImport == mainImport);
            }
            return query.ToList();
        }

        // GET api/values/5
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] UrlQuery urlQuery)
        {
            var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);
            var pagedData = _db.States
                .OrderBy(thing => thing.StateId)
                .Skip((validUrlQuery.PageNumber - 1) * validUrlQuery.PageSize)
                .Take(validUrlQuery.PageSize);
            return Ok(pagedData);
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