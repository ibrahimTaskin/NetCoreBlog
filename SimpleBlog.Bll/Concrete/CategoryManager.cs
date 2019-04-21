using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleBlog.Bll.Abstract;
using SimpleBlog.Dal.Abstract;
using SimpleBlog.Entities;

namespace SimpleBlog.Bll.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetList();
        }
    }
}
