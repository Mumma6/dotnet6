using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> chars = new List<Character>{
            new Character(),
            new Character { Name = "Sam", Id = 1 }
        };

        [HttpGet("GetAll")] // same as using both HttpGet and Route
        public ActionResult<List<Character>> Get()
        {
            return Ok(chars);
        }

        [HttpGet("{id}")] // via URL
        public ActionResult<Character> GetById(int id)
        {
            return Ok(chars.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddChar(Character data)
        {
            chars.Add(data);
            return Ok(chars);
        }
    }
}