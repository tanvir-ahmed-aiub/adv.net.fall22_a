using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BDonate.Controllers
{
    [EnableCors("*", "*", "*")]
    public class GroupController : ApiController
    {
        [Route("api/groups")]
        [HttpGet]
        public HttpResponseMessage Get() {
            var data = GroupService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/groups/{id}")]
        public HttpResponseMessage Get(int id) { 
            var data = GroupService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data); 
        }
        [HttpPost]
        [Route("api/groups/add")]
        public HttpResponseMessage Add(GroupDTO grp) {
            var data = GroupService.Add(grp);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
