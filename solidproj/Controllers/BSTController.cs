using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace solidproj.Controllers {

    [Route ("solid/")]
    [ApiController]
    public class BSTController : ControllerBase {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get () {
            return "API is up and running!";
        }

        [HttpGet ("bst/")]
        public ActionResult<string> GetBst () {
            return "bst is up";
        }

        // GET api/values/5
        [HttpGet ("{id}")]
        public ActionResult<string> Get (int id) {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post ([FromBody] string value) { }

        // PUT api/values/5
        [HttpPut ("{id}")]
        public void Put (int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public void Delete (int id) { }
    }
}