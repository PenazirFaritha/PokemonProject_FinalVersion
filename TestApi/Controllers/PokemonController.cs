using System.Collections.Generic;
using System.Web.Http;
using TestApi.Models;
using System.Web.Mvc;
using System.Web;
using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json;

namespace TestApi.Controllers
{
    public class PokemonController : ApiController
    {
        // GET api/Pokemon
        //public List<PokemonDetails> Get()
        //{
        //    pokemonfulldetails sdList = new pokemonfulldetails();
        //    return sdList.pokemonDetails;
        //}

        //// GET api/Pokemon/5
        //public string Get(int id)
        //{

        //    return "value";
        //}

        //// POST api/Pokemon
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/Pokemon/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/Pokemon/5
        //public void Delete(int id)
        //{
        //}
        public PokemonDetails Get()
        {
            using (var w = new WebClient())
            {
                String raw = w.DownloadString("https://pokeapi.co/api/v2/pokemon/2/");
                PokemonDetails poke= JsonConvert.DeserializeObject<PokemonDetails>(raw);
                return poke;
            }
        }
    }
}
