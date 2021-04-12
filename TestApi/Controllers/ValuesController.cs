using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using TestApi.Models;

namespace TestApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values


        // GET api/values/5
        public PokemonDetails[] Get(int id)
        {
            switch (id)
            {
                case 1:
                    return new PokemonDetails[]
       {

                new PokemonDetails
                {
                Id=1,
                Name="bulbasaur",
                Description="My name is bulbasaur",
                Habitat="rare",
                IsLegendary="true"
                }
       };
                case 2:
                    return new PokemonDetails[]
       {

                new PokemonDetails
                {
                Id=2,
                Name="Mewtwo",
                Description="My name is Mewtwo",
                Habitat="rare",
                IsLegendary="true"
                }
       };
                default:
                    return new PokemonDetails[]
                           {

                new PokemonDetails
                {
                Id=3,
                Name="ivysaur",
                Description="My name is Ivysaur",
                Habitat="rare",
                IsLegendary="true"
                }
                           };

            }

        }
        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
