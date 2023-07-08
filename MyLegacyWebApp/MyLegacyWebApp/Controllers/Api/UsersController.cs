using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyLegacyWebApp.Controllers.Api
{
    public class UsersController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "Dave", "Maureen" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "Mike";
        }
    }
}
