using System;
using System.Collections.Generic;
using System.Text;
using SimpleBlog.Entities;

namespace SimpleBlog.Bll.Abstract
{
    public interface IAuthorService
    {
        List<Author> GetList();
    }
}
