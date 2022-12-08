using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PostService
    {
        public static PostDTO AddPost(PostDTO post) {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<PostDTO, Post>();
                c.CreateMap<Post, PostDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Post>(post);
            var rt =DataAccessFactory.PostDataAccess().Add(data);
            if(rt != null)
            {
                return mapper.Map<PostDTO>(rt);
            }
            return null;    
        }
        public static List<PostDTO> Get() {
            var data = DataAccessFactory.PostDataAccess().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Post, PostDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<PostDTO>>(data);
        }
        public static PostDTO Get(int id) {
            var data = DataAccessFactory.PostDataAccess().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Post, PostDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<PostDTO>(data);
        }
        public static PostCommentDTO GetwithComments(int id) {
            var data = DataAccessFactory.PostDataAccess().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Post, PostCommentDTO>();
                c.CreateMap<Comment, CommentDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<PostCommentDTO>(data);
        }
    }
}
