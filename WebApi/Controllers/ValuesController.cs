using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> values()
        {

            return new List<Villa>
            {
                new Villa {Id = 1,Name = "Pool view" },
                new Villa {Id = 2,Name = "Beach view"}

            };
        }
    }
}
