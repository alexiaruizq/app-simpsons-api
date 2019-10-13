  
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using web_api_simpsons.Modules;
using web_api_simpsons.Dependencies;

namespace web_api_simpsons.Controllers
{
    [Route("simpsons/[controller]")]
    [ApiController]
    public class CharacterController : ICharacter
    {
        List<Character> listOfCharacters => new List<Character>
    {
        new Character
        {
            FirstName = "Homero",
                SecondName = "Jay",
                LastName = "Simpsons",
                Age = 34
            },
            new Character
            {
                FirstName = "Marge ",
                SecondName = " ",
                LastName = "Simpsons",
                Age = 36
            }
            new Character
            {
                FirstName = "Lisa ",
                SecondName = " ",
                LastName = "Simpsons",
                Age = 8
            }
            new Character
            {
                FirstName = "Bart ",
                SecondName = " ",
                LastName = "Simpsons",
                Age = 10
            }
            new Character
            {
                FirstName = "Maggie ",
                SecondName = " ",
                LastName = "Simpsons",
                Age = 1
            }
        };
        
        [HttpGet("{id}")]
        public Character GetCharacter(int id)
        {
            return listOfCharacters[id];
        }

        [HttpGet]
        public List<Character> GetCharacterList()
        {
            return listOfCharacters;
        }
    }
}