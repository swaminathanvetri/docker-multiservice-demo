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
            Sessions.Add(new Session { Title="Welcome & Coffee", Speaker = "-", Time="10:30 - 10:45"});
            Sessions.Add(new Session { Title="Intro & day's overview", Speaker = "-", Time="10:45 - 11:00"});
            Sessions.Add(new Session { Title="The .Net Compiler Platform (Roslyn) API", Speaker = "Vishal Anand", Time="11:00 - 11:45"});
            Sessions.Add(new Session { Title="Coffee Break", Speaker = "-", Time="11:45 - 12:00"});
            Sessions.Add(new Session { Title="CI/CD for Asp.Net core apps using Docker", Speaker = "Swaminathan Vetri", Time="12:00 - 12:45"});
            Sessions.Add(new Session { Title="Going Serverless with Azure Functions", Speaker = "Anand Gothe", Time="12:50 - 1:30"});
            Sessions.Add(new Session { Title="Lunch, Networking", Speaker = "-", Time="1:30 - 2:15"});
            Sessions.Add(new Session { Title="Quiz", Speaker = "-", Time="2:15 - 2:45"});
            Sessions.Add(new Session { Title="Azure Logic Apps", Speaker = "Vikram Chaudhary", Time="2:45 - 3:30"});
            Sessions.Add(new Session { Title="Snacks & Coffee", Speaker = "-", Time="3:30 - 3:50"});
            Sessions.Add(new Session { Title="Appium Cross platform mobile automation", Speaker = "Hanumantha Reddy GS", Time="3:50 - 4:40"});
            Sessions.Add(new Session { Title="Retrospective & Lucky draw", Speaker = "-", Time="4:40 - 5:00"});
            Sessions.Add(new Session { Title="The After Party", Speaker = "-", Time="5:00 PM"});
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
