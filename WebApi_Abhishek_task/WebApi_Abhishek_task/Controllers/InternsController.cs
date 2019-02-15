using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Abhishek_task.Models;

namespace WebApi_Abhishek_task.Controllers
{
    public class InternsController : ApiController
    {
        InternsOperation operation = new InternsOperation();
        // GET: api/Interns
        [Route("api/Interns")]
        [HttpGet]
        public String Get()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(operation.Get());
        }

        // GET: api/Interns/5
        [Route("api/Interns/{id}")]
        [HttpGet]
        public Interns Get(int id)
        {
            Interns i;
            if ((i = operation.Get(id)) != null)
                return i;
            return null;
        }

        // POST: api/Interns
        [Route("api/Interns")]
        [HttpPost]
        public String Post([FromBody]Interns value)
        {
            if (operation.Post(value) != 0)
                return "Success";
            return "Failure";
        }

        // PUT: api/Interns/5
        [Route("api/Interns")]
        [HttpPut]
        public String Put(int id, [FromBody]Interns value)
        {
            if (operation.Put(id, value.Interns_name) != 0)
                return "Success";
            return "Failure";
        }

        // DELETE: api/Interns/5
        [Route("api/Interns")]
        [HttpDelete]
        public String Delete(int id)
        {
            if (operation.Delete(id) != 0)
                return "Deleted Successfully";
            return "Operation not performed";
        }
    }
}
