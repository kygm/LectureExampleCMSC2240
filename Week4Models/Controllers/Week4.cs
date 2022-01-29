using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Week4Models.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Week4 : ControllerBase
    {

        [HttpPost(Name = "Week4")]
        public ActionResult<List<Doge>> Post([FromBody] List<Doge> input)
        {
            foreach(Doge doge in input)
            {
                System.Console.WriteLine(doge.Name);

            }
            //returning input
            return Accepted(input);
        }
    }
    public class Doge
    {
        public string Id { get; set; }
        public string Name { get; set; }
        
    }
}