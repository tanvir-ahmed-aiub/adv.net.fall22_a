using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroWebAPI.Controllers
{
    public class StudentController : ApiController
    {
        public HttpResponseMessage Get() {
            var student = new { Id = 1, Name = "Tanvir", Cgpa = "3.45" };
            return Request.CreateResponse(HttpStatusCode.OK,student);
        }
        public HttpResponseMessage Post() { 
            return Request.CreateResponse(HttpStatusCode.OK,"This is Post");   
        }
        public HttpResponseMessage Delete()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "This is Delete");
        }
        public HttpResponseMessage Put()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "This is Put");
        }
    }
}
