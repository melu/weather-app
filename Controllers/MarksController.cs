using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using weather_app.Repository;
using weather_app.Models;

namespace weather_app.Controllers
{
    [Route("api/[controller]")]
    public class MarksController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Mark> Get()
        {
            var repository = new MarkRepository();
            var response = repository.GetAll();
            return response;
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
