using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleBlog.Bll.Abstract;
using SimpleBlog.Dal.Abstract;
using SimpleBlog.Entities;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace SimpleBlog.Bll.Concrete
{
    public class PostManager:IPostService
    {
        private IPostDal _postDal;

        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

        public List<Post> GetList()
        {
            return _postDal.GetListDal();
        }

        public List<Post> GetPostList(int categoryId)
        {
            var result = _postDal.GetListDal2();
            return result;
        }
        
        public List<Post> GetPost(int postId)
        {
            var result = _postDal.GetListDal2(x=>x.PostId==postId);
            return result;
        }

        public List<Post> GetByCategoryId(int categoryId)
        {
            //category id==0 ise tüm listeyi getir
            var result= _postDal.GetList(p => p.Category.CategoryId == categoryId || categoryId == 0);
            return result.ToList();
        }
        public void Add(Post post)
        {
           _postDal.Add(post);
        }

        public void Update(Post post)
        {
            _postDal.Update(post);
        }

        public void Delete(int postId)
        {
            _postDal.Delete(new Post{PostId = postId});
        }

        public Post GetById(int postId)
        {
            return _postDal.Get(p => p.PostId == postId);
        }
    }
}
