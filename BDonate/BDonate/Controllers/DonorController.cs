using BDonate.Auth;
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
    [EnableCors("*","*","*")]
    [Logged]
    public class DonorController : ApiController
    {
        
        [Route("api/donors")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = DonorService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/donors/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = DonorService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/donors/add")]
        public HttpResponseMessage Add(DonorDTO donor)
        {
            var data = DonorService.Add(donor);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
