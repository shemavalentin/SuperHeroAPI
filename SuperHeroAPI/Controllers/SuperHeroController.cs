using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroApiDotNet7.Models;

namespace SuperHeroApiDotNet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        //Lets create a list of super heroes
         // cze no Db yet, we have to use Object Initializer to manually create a new super hero

            private static List<SuperHero> superHeroes = new List<SuperHero>
            {
                //Object initializer now

                new SuperHero 
                { Id = 1,
                    Name = "Spider Man", 
                    FirstName = "Peter", 
                    LastName = "Parker", 
                    Place = "New York City"
                },

                new SuperHero
                { Id = 2,
                    Name = " ShemaV",
                    FirstName = "Valentin",
                    LastName = "Valen",
                    Place = "CoK"
                }
            };

        [HttpGet]
        public async Task<ActionResult<SuperHero>> GetAllHeroes()
        {
            return Ok(superHeroes);
        }

        [HttpGet("{id}")]
        // TO get the Id of a hero we use Route

        //[Route("{id}")] // Or we can combine this line with the HttpGet method
        public async Task<ActionResult<List<SuperHero>>> GetSingleHeroe(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null)
                return NotFound("Sorry, This hero does not exist.");
            
            return Ok(hero);
        }

        //Method to add heroes

        [HttpPost]

        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero) // If you want to exactly be sure ure [FromBody]
        {
            superHeroes.Add(hero);
            return Ok(superHeroes);
        }


    }
}
