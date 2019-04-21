using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SimpleBlog.Core.DataAccess;
using SimpleBlog.Dal.Abstract;
using SimpleBlog.Entities;

namespace SimpleBlog.Dal.Concrete.EntityFramework
{
    public class EfPostDal:EfRepositoryBase<Post,BlogDbContext>,IPostDal
    {
        public List<Post> GetListDal()
        {
            using (var context = new BlogDbContext())
            {
                var result = context.Posts.Include(x => x.Author).Include(x => x.Category).ToList();
                return result;
            }
        }

        public List<Post> GetListDal2(Expression<Func<Post, bool>> filter = null)
        {
            using (var context = new BlogDbContext())
            {
                //var result = context.Posts.Include(
                //    x => x.Author).Include(x => x.Category).ToList();
                
                return filter == null
                    ? context.Posts.Include(
                        x => x.Author).Include(x => x.Category).ToList() 
                    //filtre boşsa tüm listeyi getir
                    : context.Posts.Include(x => x.Author).Include(c=>c.Category).Where(filter).ToList();//filtre varsa filtreli olan kısmı getir
            }
        }
    }
}
