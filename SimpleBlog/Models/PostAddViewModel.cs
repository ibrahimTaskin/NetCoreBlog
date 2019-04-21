using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleBlog.Entities;

namespace SimpleBlog.Models
{
    public class PostAddViewModel
    {
        public Post Post { get; set; }
        public List<Author> Authors { get; set; }
        public List<Category> Categories { get; set; }
    }
}
