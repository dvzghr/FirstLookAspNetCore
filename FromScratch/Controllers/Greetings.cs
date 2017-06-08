using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FromScratch.Models;
using FromScratch.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FromScratch.Controllers
{
    [Route("api/[controller]")]
    public class Greetings : Controller
    {
        private IGreetingService _greeter;

        public Greetings(IGreetingService greeter)
        {
            _greeter = greeter;
        }

        // GET: api/values
        [HttpGet]
        public GreetingMessage Get()
        {
            return _greeter.GetTodaysGreeting();
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
