using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Controllers
{
    [Route("api/hello")]
    public class HelloController : Controller
    {
        [HttpGet("arr")]
        public ArrayList getArrayString()
        {
            ArrayList arryList1 = new ArrayList();
            arryList1.Add("abc");
            arryList1.Add("abc1");
            arryList1.Add("abc2");
            arryList1.Add("abc3");
            return arryList1;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
