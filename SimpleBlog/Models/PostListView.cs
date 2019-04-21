using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleBlog.Entities;

namespace SimpleBlog.Models
{
    public class PostListView
    {
        public List<Post> Posts { get; set; }
        //public IQueryable<Post> Posts { get; set; }
        public int PageCount { get; internal set; }
        public int PageSize { get; internal set; }
        public int CurrentPage { get; internal set; }
        public int CurrentCategory { get; internal set; }
        public int PostId { get; set; }
    }
}
