using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace swaggerton_server.Controllers
{
    /// <summary>
    /// This api is for values
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class GenerateValueController : ControllerBase
    {
        /// <summary>
        /// Concatenates the params together
        /// </summary>
        /// <param name="id">Id Param</param>
        /// <param name="value1">Val1 Param</param>
        /// <param name="value2">Val2 Param</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id,string value1, string value2)
        {  
            return "value_" + id.ToString() + value1 + "_" + value2;
        }

        /// <summary>
        /// Submit a value
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Update a value
        /// </summary>
        /// <param name="id">Id of value</param>
        /// <param name="value">The value to update</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// This deletes the value
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
