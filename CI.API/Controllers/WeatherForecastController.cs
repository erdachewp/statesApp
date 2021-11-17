using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //  GET api/values http://localhost:5000/api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "State 1", "State 2" };
        }
        //  GET api/values/4
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<string>> Get(int id)
        {
            return  "State 2";
        }
        //  POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }
               //  PUT api/values/3
        [HttpPUT("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }
    }
}
