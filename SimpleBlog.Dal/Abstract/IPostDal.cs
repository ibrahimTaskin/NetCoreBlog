using SimpleBlog.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using SimpleBlog.Entities;
using Microsoft.EntityFrameworkCore;

namespace SimpleBlog.Dal.Abstract
{
    public interface IPostDal : IEntityReposityory<Post>
    {
        List<Post> GetListDal();
        List<Post> GetListDal2(Expression<Func<Post, bool>> filter = null);
        //Post'a özel methodlar
    }
}
