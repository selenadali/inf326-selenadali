using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{   public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class PersonController : Controller
    {
        public IEnumerable<Person> Get()
        {
            return new List<Person> { 
            new Person { ID = 0 , FirstName = "Scott", LastName = "Hanselman" },
            new Person { ID = 1 , FirstName = "1Scott", LastName = "1Hanselman" },
            new Person { ID = 2 , FirstName = "2Scott", LastName = "2Hanselman" },
            
            };
        }

        // GET api/values/5
        public Person Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]Person value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Person value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        
    }
}
