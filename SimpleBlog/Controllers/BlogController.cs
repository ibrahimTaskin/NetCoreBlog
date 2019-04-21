using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleBlog.Bll.Abstract;
using SimpleBlog.Entities;
using SimpleBlog.Models;

namespace SimpleBlog.Controllers
{
    public class BlogController : Controller
    {
        private IPostService _postService;

        public BlogController(IPostService postService)
        {
            _postService = postService;
        }

        public IActionResult Index(int page = 1, int categoryId = 0)
        {
            int pageSize = 10;
            //var posts = _postService.GetList2(categoryId);
            var posts = _postService.GetPostList(categoryId);
            PostListView model = new PostListView
            {
                Posts = posts,
                PageCount = (int)Math.Ceiling(posts.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = categoryId,
                CurrentPage = page
            };
            return View(model);
        }

        public IActionResult Post(int postId)
        {
            var posts = _postService.GetPost(postId);
            PostListView model = new PostListView
            {
                Posts = posts
            };
            return View(model);
        }
    }
}