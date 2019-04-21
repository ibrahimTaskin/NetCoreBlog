using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SimpleBlog.Entities.Abstract;

namespace SimpleBlog.Entities
{
    public class Post: IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostId { get; set; }
        //public int AuthorId { get; set; }
        //public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Tarih { get; set; }

        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }

    }
}
