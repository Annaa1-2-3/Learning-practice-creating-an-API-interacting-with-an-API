using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<string> Summaries = new()
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll(int? sortStrategy)
        {
            if (sortStrategy == null)
            {
                return Ok(Summaries);
            }
            else if (sortStrategy == 1)
            {
                return Ok(Summaries.OrderBy(s => s).ToList());
            }
            else if (sortStrategy == -1)
            {
                return Ok(Summaries.OrderByDescending(s => s).ToList());
            }
            else
            {
                return BadRequest("Invalid sortStrategy value");
            }
        }
        public List<string> Get()
        {
            return Summaries;
        }

        [HttpPost]
        public IActionResult Add(string name)
        {
            Summaries.Add(name);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update (int index, string name)
        {
            if (index < 0 || index >= Summaries.Count)
            {
                return BadRequest("Такой индекс неверный!!!!");
            }

            Summaries[index] = name;
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int index)
        {
            if (index < 0)
            {
                return BadRequest("Некорректное значение параметра index");
            }

            Summaries.RemoveAt(index);
            return Ok();
        }

        //2. Добавление метода для вывода одного наименования по указанному индексу:
        [HttpGet("{index}")]
        public IActionResult GetNameByIndex(int index)
        {
            if (index < 0 || index >= Summaries.Count)
            {
                return BadRequest("Некорректное значение параметра index");
            }
            return Ok(Summaries[index]);
        }

        //3. Добавление метода для получения количества записей по указываемому имени:
        [HttpGet("find-by-name")]
        public IActionResult GetCountByName(string name)
        {
            int count = Summaries.Count(s => s == name);
            return Ok(count);
        }
    }

}
