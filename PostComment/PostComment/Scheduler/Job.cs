using BLL.DTOs;
using BLL.Services;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PostComment.Scheduler
{
    public class Job : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            var post = new PostDTO() {
                Title = "AASSSAASS"
            };
            PostService.AddPost(post);
        }
    }
}