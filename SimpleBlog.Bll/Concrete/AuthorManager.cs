using System;
using System.Collections.Generic;
using System.Text;
using SimpleBlog.Bll.Abstract;
using SimpleBlog.Dal.Abstract;
using SimpleBlog.Entities;

namespace SimpleBlog.Bll.Concrete
{
    public class AuthorManager:IAuthorService
    {
        private IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public List<Author> GetList()
        {
            return _authorDal.GetList();
        }
    }
}
