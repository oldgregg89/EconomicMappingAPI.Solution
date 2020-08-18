using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EconomicMappingAPI.Models;
using Microsoft.EntityFrameworkCore;
using Dapper;
using MySqlConnector;
using Microsoft.SqlServer;
using System.Data.SqlClient;

namespace EconomicMappingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private EconomicMappingAPIContext _db;
        private SqlConnection _connectionString;

        public StateController(EconomicMappingAPIContext db, SqlConnection connectionString)
        {
            _db = db;
            _connectionString = connectionString;
        }
        // GET api/values
        [HttpGet]
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
        //public IActionResult GetContacts([FromQuery] UrlQuery urlQuery)
        public IActionResult GetStates([FromQuery] UrlQuery urlQuery)
        {
            IEnumerable<State> state = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sql = @"SELECT StateId, Name, GDP, MainExport, MainImport";

                if (urlQuery.PageNumber.HasValue)
                {
                    sql += @" ORDER By State.StatePK
                        OFFSET @PageSize * (@PageNumber -1) ROWS
                        FETCH NEXT @PageSize ROWS ONLY";
                }

                state = connection.Query<State>(sql, urlQuery);
                }
                return Ok(state);
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
