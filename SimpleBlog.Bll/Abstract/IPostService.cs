using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleBlog.Entities;

namespace SimpleBlog.Bll.Abstract
{
    public interface IPostService
    {
        List<Post> GetList();
        List<Post> GetPostList(int categoryId);
        List<Post> GetPost(int postId);
        List<Post> GetByCategoryId(int categoryId);

        void Add(Post post);
        void Update(Post post);
        void Delete(int postId);
        Post GetById(int postId);
    }
}
