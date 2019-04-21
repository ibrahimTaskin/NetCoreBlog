using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using SimpleBlog.Entities.Abstract;

namespace SimpleBlog.Core.DataAccess
{
    public interface IEntityReposityory<T> where T: class,IEntity,new()
    {
        //Tekli çağırmalar
        T Get(Expression<Func<T, bool>> filter = null);
        //Liste halinde çağırmalar
        List<T> GetList(Expression<Func<T, bool>> fiter = null);
        List<T> GetList2(Expression<Func<T, bool>> fiter = null);
        
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
