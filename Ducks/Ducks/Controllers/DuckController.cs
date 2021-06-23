using AngleSharp.Text;
using Ducks.Enums;
using Ducks.Mapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Ducks.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DuckController : ControllerBase
    {
        private DuckMapper duckMapper;

        public DuckController()
        {
            duckMapper = new DuckMapper();
        }

        [HttpGet]
        [Route("{duck}/display")]
        public IActionResult DisplayDuck(string duck)
        {
            var duckFinded = duckMapper.duckDictionary.First(x => x.Key == duck.ToEnum(DucksEnum.MallardDuck)).Value;
            return Ok(duckFinded.Display());
        }

        [HttpGet]
        [Route("{duck}/quack")]
        public IActionResult QuackDuck(string duck)
        {
            var duckFinded = duckMapper.duckDictionary.First(x => x.Key == duck.ToEnum(DucksEnum.MallardDuck)).Value;
            return Ok(duckFinded.PerformQuack());
        }

        [HttpGet]
        [Route("{duck}/fly")]
        public IActionResult FlyDuck(string duck)
        {
            var duckFinded = duckMapper.duckDictionary.First(x => x.Key == duck.ToEnum(DucksEnum.MallardDuck)).Value;
            return Ok(duckFinded.PerformFly());
        }
    }
}
