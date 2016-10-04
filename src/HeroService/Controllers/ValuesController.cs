using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HeroService.Models;

namespace HeroService.Controllers
{
    [Route("api/values")]
    public class ValuesController : Controller
    {
        private IEnumerable<Hero> heroes = new Hero[] { new Hero() { name = "Abert's Towhee", id = 1 },
            new Hero() { name = "Acadian Flycatcher", id = 2 },
            new Hero(){ name = "Acorn Woodpecker", id = 3 },
            new Hero(){ name = "African Collared-Dove", id = 4 }
        };
        // GET api/values
        [HttpGet("")]
        public IEnumerable<Hero> Get()
        {
            return heroes;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Hero Get(int id)
        {
            return this.heroes.FirstOrDefault(h => h.id == id);
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
