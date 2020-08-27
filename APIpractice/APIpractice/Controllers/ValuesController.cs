using APIpractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIpractice.Controllers
{
    public class ValuesController : ApiController
    {

        [Route("Search")]
        [HttpGet]
        // GET api/values
        public IEnumerable<Data> Search()
        {
            List<Data> data = new List<Data>();
            data.Add(new Data {
                 name = "王大明",
                 ename = "Jason"
                });
            data.Add(new Data
            {
                name = "李天才",
                ename = "Tom"
            });
            data.Add(new Data
            {
                name = "黃超人",
                ename = "Clerk"
            });





            return data;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
