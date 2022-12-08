using PostComment.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace PostComment
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            PostScheduler.Run();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
