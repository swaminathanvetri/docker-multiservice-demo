using System.Collections.Generic;
using bdotnet_webapi_demo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bdotnet_webapi_demo
{
    [Route("api/[controller]")]
    public class SessionsController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Session> Get()
        {
            List<Session> Sessions = new List<Session>();
            Sessions.Add(new Session { Title="Intro to Docker", Speaker = "Neependra", Time="09:30 - 11:00"});
            Sessions.Add(new Session { Title="Break/Networking", Speaker = "-", Time="11:00 - 11:15"});
            Sessions.Add(new Session { Title="Docker for .Net apps", Speaker = "Swami", Time="11:15 - 12:45"});
            return Sessions;
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
