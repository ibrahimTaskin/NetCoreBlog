using System;
using System.Collections.Generic;
using System.Text;
using SimpleBlog.Core.DataAccess;
using SimpleBlog.Dal.Abstract;
using SimpleBlog.Entities;

namespace SimpleBlog.Dal.Concrete.EntityFramework
{
    public class EfAuthorDal:EfRepositoryBase<Author,BlogDbContext>,IAuthorDal
    {
    }
}
