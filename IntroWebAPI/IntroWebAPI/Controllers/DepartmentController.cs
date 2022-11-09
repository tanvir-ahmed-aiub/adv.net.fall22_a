using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroWebAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        [HttpGet]
        [Route("api/dept/all")]
        public HttpResponseMessage Depts()
        {
            return Request.CreateResponse(HttpStatusCode.Forbidden,"ok");
        }
    }
}
